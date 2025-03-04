using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Drawing;
using QRCoder;

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для QrFFF.xaml
    /// </summary>
    public partial class QrFFF : Page
    {
        public QrFFF()
        {
            InitializeComponent();
        }

        private void createQrBtn_Click(object sender, RoutedEventArgs e)
        {
            string soucer_xl = "https://sun9-53.userapi.com/impf/c625731/v625731854/b1e2/Gn7wXVqkbN8.jpg?size=807x504&quality=96&sign=cb32ffe01f4c799b9722d2086440717f&c_uniq_tag=IyOdz6hfWsU2wupuKKHO-sTrbnzp9KUlqmJR1tDUjd0&type=album";  //ссылка на хл страницу
            QRCoder.QRCodeGenerator qr=new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData data = qr.CreateQrCode(soucer_xl, QRCoder.QRCodeGenerator.ECCLevel.L) ;

            QRCoder.QRCode code = new QRCoder.QRCode(data);
            Bitmap bitmap = code.GetGraphic(100);

            //создание картинки
            using(MemoryStream memory=new MemoryStream())
            {
                bitmap.Save(memory,System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                imageQr.Source = bitmapImage;
            }

        }
    }
}
