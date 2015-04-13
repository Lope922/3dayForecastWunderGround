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

        '' //icon for a brief description of the weather 
        Dim xmlIconDescription As XmlNode = xmlWeatherReader.SelectSingleNode("//icon")
        '' //icon_url as the icon image to read from the stream 

        Dim xmlIconRequestURL As XmlNode = xmlWeatherReader.SelectSingleNode("//icon_url")

        lblDay.Text = xmlDay.InnerText
        ''// fctext equals forecast text description 

        lblTemp.Text = xmlIconDescription.InnerText

        testLabel.Text = xmlIconRequestURL.InnerText
        '' now get the image for the forecast and draw it to the picture box 
        Try
            Dim icon_url As String = xmlIconRequestURL.InnerText
            Dim iconWebRequest As WebRequest = WebRequest.Create(icon_url)
            Dim webimageResonse As Stream = iconWebRequest.GetResponse.GetResponseStream()

            Dim weatherDay1Icon As Image = Image.FromStream(webimageResonse)

            'Dim g As Graphics

            'forcastImageBox = g.DrawImage(Image.FromStream(weatherDay1Icon), New Rectangle(0, 0, forcastImageBox.Width, forcastImageBox.Height))
            forcastImageBox.Image = weatherDay1Icon

        Catch ex As WebException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub testLabel_Click(sender As Object, e As EventArgs) Handles testLabel.Click

    End Sub
End Class
