using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BootCamp.Chapter
{
	public class TransactionSerializer
	{
		private readonly IMapper _mapper = SetupMapper();
		private static IMapper SetupMapper()
		{
			var config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Transaction, TransactionDTO>();
				cfg.CreateMap<TransactionDTO, Transaction>();
			});

			return new Mapper(config);
		}

		public IEnumerable<Transaction> DeserializeFile(string inputFile)
		{
			//Validate input file
			if (!File.Exists(inputFile)) throw new NoTransactionsFoundException();
			//Prepare DTO list variable
			List<TransactionDTO> transactionDTOs = null;
			//Get text from file
			string fileText = File.ReadAllText(inputFile);
			//Check if file is XML or JSON
			switch (Path.GetExtension(inputFile))
			{
				case ".json":
					transactionDTOs = JsonConvert.DeserializeObject<List<TransactionDTO>>(fileText);
					break;
				case ".xml":
					//Convert to Json first as it's easier to handle (Just needs additional wrapper classes)
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(fileText);
					string jsonFileText = JsonConvert.SerializeXmlNode(xmlDocument);
					transactionDTOs = JsonConvert.DeserializeObject<JsonTransactionsDTO>(jsonFileText).TransactionsDTO.Transactions;

					//Couldn't figure out how to deserialize a standard XML file
					//XmlSerializer xmlSerializer = new XmlSerializer(typeof(TransactionsDTO));
					//using (TextReader reader = new StringReader(fileText))
					//{
					//	var test = (TransactionsDTO)xmlSerializer.Deserialize(reader);
					//}
					break;
			}

			//Convert DTO to Transaction obj
			return transactionDTOs.Select(dto => _mapper.Map<Transaction>(dto)).ToList();
		}

		public void SerializeFile(string outputFile, object dto)
		{
			//Serialize based on output file extension type
			string resultFileText = Path.GetExtension(outputFile) switch
			{
				".json" => JsonConvert.SerializeObject(dto, Newtonsoft.Json.Formatting.Indented),
				".xml" => SerializeXml(dto),
				_ => dto.ToString()
			};

			File.WriteAllText(outputFile, resultFileText);
		}

		private string SerializeXml(object dto)
		{
			//Disable xmlns text from file
			XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
			//Create serializer
			XmlSerializer serializer = new XmlSerializer(dto.GetType());
			//Disable xml declarations
			XmlWriterSettings settings = new XmlWriterSettings()
			{
				Indent = true,
				OmitXmlDeclaration = true
			};

			string resultText;
			using (StringWriter stringWriter = new StringWriter())
			{
				using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
				{
					serializer.Serialize(xmlWriter, dto, xmlns);
					resultText = stringWriter.ToString();
				}
			}

			return resultText;
		}
	}
}
