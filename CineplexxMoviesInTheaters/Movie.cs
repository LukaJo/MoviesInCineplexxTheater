using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using YoutubeSearch;

namespace CineplexxMoviesInTheaters
{
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
            PopuniImageBox();
            PopuniTextILinkove();
        }


        private void PopuniTextILinkove()
        {

            var doc = new HtmlWeb().Load(@"https://www.cineplexx.rs/filmovi/u-bioskopu/");

            var lista = doc.DocumentNode.SelectNodes("//div[@class='span3']//h2//a").Select(a => a.InnerText).ToList();

            linkLabel1.Text = lista[0].ToString();
            linkLabel2.Text = lista[1].ToString();
            linkLabel3.Text = lista[2].ToString();
            linkLabel4.Text = lista[3].ToString();
            linkLabel5.Text = lista[4].ToString();
            linkLabel6.Text = lista[5].ToString();
            linkLabel7.Text = lista[6].ToString();
            linkLabel8.Text = lista[7].ToString();
            linkLabel9.Text = lista[8].ToString();
            linkLabel10.Text = lista[9].ToString();
            linkLabel11.Text = lista[10].ToString();
            linkLabel12.Text = lista[11].ToString();

            var lista1 = doc.DocumentNode.SelectNodes("//div[@class='span3']//h2//a").Select(a => a.GetAttributeValue("href", null)).ToList();

            linkLabel1.Links[0].LinkData = "https:" + lista1[0].ToString();
            linkLabel2.Links[0].LinkData = "https:" + lista1[1].ToString();
            linkLabel3.Links[0].LinkData = "https:" + lista1[2].ToString();
            linkLabel4.Links[0].LinkData = "https:" + lista1[3].ToString();
            linkLabel5.Links[0].LinkData = "https:" + lista1[4].ToString();
            linkLabel6.Links[0].LinkData = "https:" + lista1[5].ToString();
            linkLabel7.Links[0].LinkData = "https:" + lista1[6].ToString();
            linkLabel8.Links[0].LinkData = "https:" + lista1[7].ToString();
            linkLabel9.Links[0].LinkData = "https:" + lista1[8].ToString();
            linkLabel10.Links[0].LinkData = "https:" + lista1[9].ToString();
            linkLabel11.Links[0].LinkData = "https:" + lista1[10].ToString();
            linkLabel12.Links[0].LinkData = "https:" + lista1[11].ToString();

        }


        private void PopuniImageBox()
        {

            var doc = new HtmlWeb().Load(@"https://www.cineplexx.rs/filmovi/u-bioskopu/");

            var lista = doc.DocumentNode.SelectNodes("//div[@class='img-holder']//a/img").Select(a => a.GetAttributeValue("data-original", null)).ToList();

            pictureBox1.ImageLocation = "https:" + lista[0].ToString(); pictureBox13.Parent = pictureBox1; pictureBox13.Location = Point.Empty;
            pictureBox2.ImageLocation = "https:" + lista[1].ToString(); pictureBox14.Parent = pictureBox2; pictureBox14.Location = Point.Empty;
            pictureBox3.ImageLocation = "https:" + lista[2].ToString(); pictureBox15.Parent = pictureBox3; pictureBox15.Location = Point.Empty;
            pictureBox4.ImageLocation = "https:" + lista[3].ToString(); pictureBox16.Parent = pictureBox4; pictureBox16.Location = Point.Empty;
            pictureBox5.ImageLocation = "https:" + lista[4].ToString(); pictureBox17.Parent = pictureBox5; pictureBox17.Location = Point.Empty;
            pictureBox6.ImageLocation = "https:" + lista[5].ToString(); pictureBox18.Parent = pictureBox6; pictureBox18.Location = Point.Empty;
            pictureBox7.ImageLocation = "https:" + lista[6].ToString(); pictureBox19.Parent = pictureBox7; pictureBox19.Location = Point.Empty;
            pictureBox8.ImageLocation = "https:" + lista[7].ToString(); pictureBox20.Parent = pictureBox8; pictureBox20.Location = Point.Empty;
            pictureBox9.ImageLocation = "https:" + lista[8].ToString(); pictureBox21.Parent = pictureBox9; pictureBox21.Location = Point.Empty;
            pictureBox10.ImageLocation = "https:" + lista[9].ToString(); pictureBox22.Parent = pictureBox10; pictureBox22.Location = Point.Empty;
            pictureBox11.ImageLocation = "https:" + lista[10].ToString(); pictureBox23.Parent = pictureBox11; pictureBox23.Location = Point.Empty;
            pictureBox12.ImageLocation = "https:" + lista[11].ToString(); pictureBox24.Parent = pictureBox12; pictureBox24.Location = Point.Empty;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var link = ((LinkLabel)sender).Links[0].LinkData.ToString();

            var doc = new HtmlWeb().Load(link);

            var lista = doc.DocumentNode.SelectNodes("//div[@class='span8 filmdetails']").Descendants("tr")
            .Where(tr => tr.Elements("td").Count() > 1)
            .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
            .ToList();

            MovieDetails frm = new MovieDetails(lista);
            frm.ShowDialog();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            var clickedPictureBox = ((PictureBox)sender).Name;
            var link = string.Empty;

            switch (clickedPictureBox)
            {
                case "pictureBox13":
                    link = linkLabel1.Links[0].LinkData.ToString();
                    break;
                case "pictureBox14":
                    link = linkLabel2.Links[0].LinkData.ToString();
                    break;
                case "pictureBox15":
                    link = linkLabel3.Links[0].LinkData.ToString();
                    break;
                case "pictureBox16":
                    link = linkLabel4.Links[0].LinkData.ToString();
                    break;
                case "pictureBox17":
                    link = linkLabel5.Links[0].LinkData.ToString();
                    break;
                case "pictureBox18":
                    link = linkLabel6.Links[0].LinkData.ToString();
                    break;
                case "pictureBox19":
                    link = linkLabel7.Links[0].LinkData.ToString();
                    break;
                case "pictureBox20":
                    link = linkLabel8.Links[0].LinkData.ToString();
                    break;
                case "pictureBox21":
                    link = linkLabel9.Links[0].LinkData.ToString();
                    break;
                case "pictureBox22":
                    link = linkLabel10.Links[0].LinkData.ToString();
                    break;
                case "pictureBox23":
                    link = linkLabel11.Links[0].LinkData.ToString();
                    break;
                case "pictureBox24":
                    link = linkLabel12.Links[0].LinkData.ToString();
                    break;
            }


            var doc = new HtmlWeb().Load(link);

            var lista = doc.DocumentNode.SelectNodes("//div[@class='span8 filmdetails']").Descendants("tr")
            .Where(tr => tr.Elements("td").Count() > 1)
            .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
            .ToList();

            var ime = lista[0][1].ToString();
            var godina = lista[1][1].ToString().Substring(6);

            var url = new VideoSearch().SearchQuery(ime + "movie trailer" + godina, 1).Select(m => m.Url).First();
            System.Diagnostics.Process.Start(url);

        }


    }
}
