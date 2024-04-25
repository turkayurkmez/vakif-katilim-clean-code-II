using System.Data.SqlClient;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Single Responsibility Principle - SRP:
         * Bir nesnenin uygulama içinde sadece bir sorumluluğu olmalı.
         * Bir sınıf içinde değişiklik yapmak için birden fazla sebebiniz varsa, prensibi ihlal ediyorsunuz demektir.
         * 
         * Ey Form1, senin bu uygulamadaki sorumluluğun nedir?
         *   - Benim sorumluluğum, kullanıcıdan gelen verileri alıp, gerekirse denetleyip ilgili nesneye iletmek ve kullanıcının uygulamayla etkileşimini sağlamaktır.
         */

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            var affectedRows = new ProductService().CreateProduct(productName, price);
            string message = affectedRows > 0 ? $"{textBoxProductName.Text} başarıyla eklendi" : "Ürün ekleme başarısız oldu";
            new MailSender().SendMail("admin@sales.com", message);
        }

     

    

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }
    }
}
