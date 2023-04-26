using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_4
{
    internal class Invoice
    {
        private readonly int account;
        private readonly Сustomer client;
        private readonly Provider provider;

        private Product[] product;
        private int invicePrice = default;
        public bool InPDV { get; set; } 

        public int InvicePrice
        {
            get 
            {
                foreach (var item in product)
                {
                    invicePrice += item.Price * item.Quantity;
                }

                return invicePrice; 
            }
            set
            {
                invicePrice = value;
            }
        }

        public Invoice(Сustomer client, Provider provider, Product[] product)
        {
            this.account = new Random().Next(1000, 9999);
            this.client = client;
            this.provider = provider;
            this.product = product;
        }


        public void ShowInvoiceInfo()
        {
            Console.WriteLine(new String('=', 80));
            Console.WriteLine($"Інвойс №{account}");
            Console.WriteLine(new String('-', 80));
            client.ShowInfo();
            provider.ShowInfo();
            Console.WriteLine($" Імя | Цена (грн\\шт) | Кількість (шт) ");

            foreach (var item in product)
            {
                item.ShowInfoProduct();
            }

            Console.WriteLine(CalculatPDV());
            Console.WriteLine(new String('=', 80));
        }

        private string CalculatPDV()
        {
            string resPDV = default;
            if (InPDV)
            {
                InvicePrice = (InvicePrice * 20) / 100;
                resPDV = $"Сума дял опалти с ПДВ: {InvicePrice}";
            }
            else
            {
                resPDV = $"Сума дял опалти БЕЗ ПДВ: {InvicePrice}";
            }

            return resPDV;
        }


    }
}
