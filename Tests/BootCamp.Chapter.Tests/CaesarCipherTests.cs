using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class CaesarCipherTests
    {
        [Theory]
        [InlineData("", 1, "")]
        [InlineData(null, 1, null)]
        [InlineData("a", 1, "b")]
        [InlineData("a", 2, "c")]
        [InlineData("ab", 1, "bc")]
        [InlineData("ab", 2, "cd")]
        public void Encrypt_Message_With_Shift_Under_255_Returns_Encrypted_Message(string message, byte shift, string expectedEncryptedMessage)
        {
            var encryptedMessage = CaesarCipher.Encrypt(message, shift);

            encryptedMessage.Should().Be(expectedEncryptedMessage);
        }

        [Theory]
        [InlineData("", 1, "")]
        [InlineData(null, 1, null)]
        [InlineData("b", 1, "a")]
        [InlineData("c", 2, "a")]
        [InlineData("bc", 1, "ab")]
        [InlineData("cd", 2, "ab")]
        public void Decrypt_Message_With_Shift_Under_255_Returns_Decrypted_Message(string message, byte shift, string expectedEncryptedMessage)
        {
            var decryptedMessage = CaesarCipher.Decrypt(message, shift);

            decryptedMessage.Should().Be(expectedEncryptedMessage);
        }

        [Fact]
        public void Encrypt_Then_Decrypt_Returns_Original_Message()
        {
            const string message = "Hello encryption!";
            const byte shift = 1;
            var encryptedMessage = CaesarCipher.Encrypt(message, shift);
            var decryptedMessage = CaesarCipher.Decrypt(encryptedMessage, shift);

            decryptedMessage.Should().Be(message, "Because decryption is the inverse operation of encryption.");
        }

    }
}
