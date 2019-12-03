using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using ExtendedXmlSerializer.ExtensionModel.Content;
using ExtendedXmlSerializer.ExtensionModel.Types;
using ExtendedXmlSerializer.ExtensionModel.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestSerializer
{
    public class AA
    {
        public AA() { }
        public int JJ { get; set; }
        public string TT { get; set; }
    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IExtendedXmlSerializer serializer =
                new ConfigurationContainer().EnableMemberExceptionHandling().Create();
                //.EnableAllConstructors()//enable deserializing of objects private constructors
                //.EnableReaderContext().Create();//For outputing detailed information about unknown xml elements - line number, ...

            AA aa = new AA();

            using (MemoryStream stream = new MemoryStream())
            {
                try
                {
                    serializer.Serialize(stream, aa);
                }
                catch(Exception ex)
                {
                    int iii = 3;
                }
                stream.Seek(0, SeekOrigin.Begin);
                var bb = stream.ToArray();
                int ii = 3;
            }

            
        }
    }
}
