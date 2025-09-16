using Cardapio.Entities;

namespace Cardapio.Services
{
    public class PaymentService
    {

        public static List<PaymentOption> GetPaymentOptions()
        {
            return new List<PaymentOption>
            {
                new PaymentOption
                {
                    Name = "Dinheiro",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/f528df5a-7a3a-4b5a-b455-aec67204b4c1"
                },
                new PaymentOption
                {
                    Name = "Mastercard - Débito",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/ca34f400-9ba1-49c9-9f08-d269f97fd678"
                },
                new PaymentOption
                {
                    Name = "Visa - Débito",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/3fc410d4-a5ea-424c-8ef1-4847fc23723e"
                },
                new PaymentOption
                {
                    Name = "Elo - Débito",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/70764a4a-84bb-4697-82e2-7e63d88f4aa3"
                },
                new PaymentOption
                {
                    Name = "Banricompras - Débito",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/83f7d201-7d58-4d4e-8ef0-7111817230c7"
                },
                new PaymentOption
                {
                    Name = "Hipercard - Crédito",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/bdeb3d59-e42f-48a7-ae63-d064e3ef9cab"
                },
                new PaymentOption
                {
                    Name = "Visa - Crédito",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/3fc410d4-a5ea-424c-8ef1-4847fc23723e"
                },
                new PaymentOption
                {
                    Name = "Mastercard - Crédito",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/ca34f400-9ba1-49c9-9f08-d269f97fd678"
                },
                new PaymentOption
                {
                    Name = "Elo - Crédito",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/70764a4a-84bb-4697-82e2-7e63d88f4aa3"
                },
                new PaymentOption
                {
                    Name = "Amex - Crédito",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/b2a613b7-f9de-424b-9ee8-35c4f692f771"
                },
                // Vale-refeição
                new PaymentOption
                {
                    Name = "Green Card refeição - Vale-refeição",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/ab858a07-a3c2-4c0e-b7eb-623420323961"
                },
                new PaymentOption
                {
                    Name = "VR refeição - Vale-refeição",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/07b1c8c2-0e38-424e-9fa2-6ea70e5f1dd3"
                },
                new PaymentOption
                {
                    Name = "Pluxee Refeição (Sodexo Refeição) - Vale-refeição",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/5c647f4a-7a63-4adb-b70c-129d613ca637"
                },
                new PaymentOption
                {
                    Name = "Ticket - Vale-refeição",
                    IconSrc = "https://static.ifood-static.com.br/image/upload/t_thumbnail/icones/payments/brands/812a9a76-b215-4e1e-b9ef-b6db15c92e22"
                }
            };
        }
    }
}
