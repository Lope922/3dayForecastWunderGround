Imports System.Net
Imports System.IO
Imports System.Xml

Public Class Form1
   


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' the test url 
        Dim test_url As String = "http://api.wunderground.com/api/ede6553743c4d570/forecast/q/MO/St_Louis.xml"

        'the web request 
        Dim webRequestForecast As WebRequest = WebRequest.Create(test_url)

        '' comes back as a stream, prepare a variable to handle/process stream 
        Dim forecastResponseStream As Stream = webRequestForecast.GetResponse.GetResponseStream()

        Dim xmlWeatherReader As New XmlDocument
        xmlWeatherReader.Load(forecastResponseStream)

        '' from the response stream i need to be able to read. 
        Dim xmlDay As XmlNode = xmlWeatherReader.SelectSingleNode("//title")
        ''  //title as day of the week 

        'trying to access a specific day in the returned list of title elements. The 3rd day is what i want. 
        Dim xmlday2 As XmlNode = xmlWeatherReader.SelectSingleNode("//forecastday[3]/title")
        Dim xmlNodeDay2url_icon As XmlNode = xmlWeatherReader.SelectSingleNode("//forecastday[3]/icon_url")
        Dim xmlday2Description As XmlNode = xmlWeatherReader.SelectSingleNode("//forecastday[3]/icon")

        lblDay2.Text = xmlday2.InnerText
        lblDescription2.Text = xmlday2Description.InnerText

        Dim xmlday3 As XmlNode = xmlWeatherReader.SelectSingleNode("//forecastday[5]/title")
        Dim xmlNodeDay3url_icon As XmlNode = xmlWeatherReader.SelectSingleNode("//forecastday[5]/icon_url")
        Dim xmlday3Description As XmlNode = xmlWeatherReader.SelectSingleNode("//forecastday[5]/icon")

        lblDay3.Text = xmlday3.InnerText
        lblDescription3.Text = xmlday3Description.InnerText

        '' //icon for a brief description of the weather 
        Dim xmlIconDescription As XmlNode = xmlWeatherReader.SelectSingleNode("//icon")
        '' //icon_url as the icon image to read from the stream 
        MessageBox.Show("day 2 " + xmlday2.InnerXml)
        Dim xmlIconRequestURL As XmlNode = xmlWeatherReader.SelectSingleNode("//icon_url")

        lblDay.Text = xmlDay.InnerText
        ''// fctext equals forecast text description 

        lblTemp.Text = xmlIconDescription.InnerText

        'testLabel.Text = xmlIconRequestURL.InnerText
        '' now get the image for the forecast and draw it to the picture box 
        Try
            Dim icon_url As String = xmlIconRequestURL.InnerText
            Dim icon2 As String = xmlNodeDay2url_icon.InnerText
            Dim icon3 As String = xmlNodeDay3url_icon.InnerText


            Dim iconWebRequest As WebRequest = WebRequest.Create(icon_url)
            
            Dim webimageResonse As Stream = iconWebRequest.GetResponse.GetResponseStream()

            Dim weatherDay1Icon As Image = Image.FromStream(webimageResonse)
            forcastImageBox1.Image = weatherDay1Icon

            Dim iconWebRequest2 As WebRequest = WebRequest.Create(icon2)

            Dim webimageResonse2 As Stream = iconWebRequest2.GetResponse.GetResponseStream()

            Dim weatherDayIcon2 As Image = Image.FromStream(webimageResonse2)
            forcastImageBox2.Image = weatherDayIcon2

            Dim iconWebRequest3 As WebRequest = WebRequest.Create(icon3)

            Dim webimageResonse3 As Stream = iconWebRequest3.GetResponse.GetResponseStream()

            Dim weatherDayIcon3 As Image = Image.FromStream(webimageResonse3)
            forcastImageBox3.Image = weatherDayIcon3

          
            


            'Dim g As Graphics

            'forcastImageBox = g.DrawImage(Image.FromStream(weatherDay1Icon), New Rectangle(0, 0, forcastImageBox.Width, forcastImageBox.Height))


        Catch ex As WebException
            MessageBox.Show(ex.Message)
        End Try
    End Sub



End Class
