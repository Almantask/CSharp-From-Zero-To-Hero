using System;
using System.Collections.Generic;
using System.Linq;
using BootCamp.Chapter.Dummies.Orders;

namespace BootCamp.Chapter.Dummies
{
    public class DeliveryService
    {
        private readonly INotifier _notifier;
        private readonly ISender _sender;
        private readonly IDeliveriesRepository _deliveriesRepo;
        private readonly ICouriersRepository _couriersRepo;

        public DeliveryService(INotifier notifier, ISender sender, IDeliveriesRepository deliveriesRepo, ICouriersRepository couriersRepo)
        {
            _notifier = notifier;
            _sender = sender;
            _deliveriesRepo = deliveriesRepo;
            _couriersRepo = couriersRepo;
        }

        public void Deliver(Order order, string address)
        {
            var delivery = new Delivery(0, order);

            _notifier.Notify(address);

            var availableCouriers = _couriersRepo.GetAllAvailable(address);
            if (!availableCouriers.Any())
            {
                throw new Exception("No available couriers");
            }
            else
            {
                _sender.Send(delivery, address, availableCouriers.FirstOrDefault());
                _deliveriesRepo.Save(delivery);
            }
        }
    }

    public interface ICouriersRepository
    {
        IEnumerable<Courier> GetAllAvailable(string address);
    }

    public class Courier
    {
    }

    public interface IDeliveriesRepository
    {
        void Save(Delivery delivery);
    }

    public interface ISender
    {
        void Send(Delivery delivery, string address, Courier courier);
    }

    public interface INotifier
    {
        void Notify(object target);
    }

    public class Delivery
    {
        public long Id { get; }
        public Order Order { get; }

        public Delivery(long id, Order order)
        {
            Id = id;
            Order = order;
        }
    }
}
