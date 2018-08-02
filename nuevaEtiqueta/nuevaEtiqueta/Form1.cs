using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Threading;
using System.Globalization;
using iTextSharp;
using iTextSharp.text.pdf;

namespace nuevaEtiqueta
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        //Diccionarios
        Dictionary<string, string> etProductor = new Dictionary<string, string>();
        Dictionary<string, string> etVariedades = new Dictionary<string, string>();
        Dictionary<string, string> etEspecie = new Dictionary<string, string>();
        //Dictionary<string, string> etAcopio = new Dictionary<string, string>();

        Barcode128 code128 = new Barcode128();
        Random random = new Random();
        int randomNumber = -1;
        Boolean estado;
        private Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            //this.getPrinters();   IMPRESORAS
            eliminarArchivos();   
            cargarXML(); 
        }


        public void cargarXML()
        {
            estado = true;

            if (!File.Exists(@"C:\temp\productor.xml"))
            {
                try
                {
                    File.Copy(Application.StartupPath + @"\productor.xml", @"C:\temp\productor.xml");
                    //crear carpeta
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error : "+ ex);
                    estado = false;

                }
            }
            if (estado == true)
            {

                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                doc.Load(@"C:\temp\productor.xml");

                //Productor
                XmlNodeList nodoProductor = doc.GetElementsByTagName("productores");
                foreach (XmlNode node in nodoProductor[0].ChildNodes)
                {
                    etProductor.Add(node.Attributes["id"].Value, node.InnerXml);

                }
                //Variedad

                XmlNodeList nodoVariedades = doc.GetElementsByTagName("variedades");
                foreach (XmlNode node in nodoVariedades[0].ChildNodes)
                {
                    etVariedades.Add(node.Attributes["idm"].Value, node.InnerText);

                }
                comboVariedad.DataSource = new BindingSource(etVariedades, null);
                comboVariedad.DisplayMember = "Value";
                comboVariedad.ValueMember = "Key";

                //Especie

                XmlNodeList nodoEspecie = doc.GetElementsByTagName("especies");
                foreach (XmlNode node in nodoEspecie[0].ChildNodes)
                {
                    etEspecie.Add(node.Attributes["id"].Value, node.InnerText);
                }
                comboEspecie.DataSource = new BindingSource(etEspecie, null);
                comboEspecie.DisplayMember = "value";
                comboEspecie.ValueMember = "key";
            }
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            crearBarCode();
        }

        private void txtProductor_TextChanged(object sender, EventArgs e)
        {
            if (etProductor.ContainsKey(txtProductor.Text))
            {
                string productor = "<datos>" + etProductor[txtProductor.Text] + "</datos>";

                XmlDocument doc = new XmlDocument();
                String s = "hello";
                doc.LoadXml(String.Format(productor, s));

                XmlNodeList nodoNombre = doc.GetElementsByTagName("nombre");
                XmlNodeList nodoCod = doc.GetElementsByTagName("cod");

                lblNomProductor.Text = nodoNombre.Item(0).InnerText;
                lblCodProductor.Text = nodoCod.Item(0).InnerText;

                crearBarCode();
            }



        }

        private void comboVariedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> variedad = (KeyValuePair<string, string>)comboVariedad.SelectedItem;
            
            if (variedad.Value.ToString() != "Seleccione")
            {
                lblVariedad.Text = variedad.Value.ToString();
            }

            crearBarCode();
        }

        private void comboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> especie = (KeyValuePair<string, string>)comboEspecie.SelectedItem;

            if (especie.Value.ToString() != "Seleccion")
            {
                lblEspecie.Text = especie.Value.ToString();
            }

            crearBarCode();
        }



        //elimina archivos de la carpeta C:\temp
        private void eliminarArchivos()
        {
            string[] ficherosCarpeta = Directory.GetFiles(@"c:\temp");
            foreach (string ficheroActual in ficherosCarpeta)
                File.Delete(ficheroActual);
        }
        //------------------------------------------------------------------------------------

        //crear codigo de barras
        public int crearBarCode()
        {
            if (!ValidaCampos("barra"))
            {

                return 0;
            }

            if (randomNumber != -1) Image.FromFile(Application.StartupPath + @"\temp\" + randomNumber + ".bmp").Dispose();


            code128.Code = txtProductor.Text + "" + comboEspecie.SelectedValue.ToString() + "" + comboVariedad.SelectedValue.ToString();

            // Create a blank image 
            System.Drawing.Bitmap bmpimg = new Bitmap(600, 80);
            //bmpimg.SetResolution(960.0F, 960.0F);

            // provide width and height based on the barcode image to be generated. harcoded for sample purpose

            Graphics bmpgraphics = Graphics.FromImage(bmpimg);
            bmpgraphics.Clear(Color.White); // Provide this, else the background will be black by default
            Point ulCorner = new Point(0, 0);
            Point urCorner = new Point(250, 0);
            Point llCorner = new Point(0, 38);
            Point[] destPara = { ulCorner, urCorner, llCorner };
            // generate the code128 barcode
            bmpgraphics.DrawImage(code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White), 15, 0);
            bmpgraphics.DrawImage(code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White), 15, 10);

            //generate the text below the barcode image. If you want the placement to be dynamic, calculate the point based on size of the image
            bmpgraphics.DrawString(code128.Code, new System.Drawing.Font("Arial", 8, FontStyle.Regular), SystemBrushes.WindowText, new Point(35, 38));

            // Save the output stream as gif. You can also save it to external file
            MemoryStream ms = new MemoryStream();

            randomNumber = random.Next(0, 100000);
            bmpimg.Save(Application.StartupPath + @"\temp\" + randomNumber + ".bmp", System.Drawing.Imaging.ImageFormat.Gif);

            imgBarcode.Image = Image.FromFile(Application.StartupPath + @"\temp\" + randomNumber + ".bmp");

            return 0;
        }









        //valida 
        private bool ValidaCampos(string cod)
        {
            if (cod == "barra")
            {
                if(txtProductor.Text != "" && comboEspecie.SelectedValue.ToString() != "" &&
                    comboVariedad.SelectedValue.ToString() != "" &&
                    numericUpDown1.Value > 0 && numericUpDown1.Value < 9999 )//numero cajas
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }/*
            else if (cod == "imprimir")
            {
                if (
                    textBoxLote.Text != "" &&
                    textBoxProductor.Text != "" &&
                    comboMaterial.SelectedValue.ToString() != "" &&
                    comboAcopio.SelectedValue.ToString() != "" &&
                    comboVariedad.SelectedValue.ToString() != "" &&
                    numericUpCajas.Value != 0

                    )
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos solicitados antes de imprimir");
                    return false;
                }
            }*/

            return false;
        }





    }
}
