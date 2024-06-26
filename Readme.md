<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609043/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2216)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RichEditSendMail/Form1.cs) (VB: [Form1.vb](./VB/RichEditSendMail/Form1.vb))
* [Program.cs](./CS/RichEditSendMail/Program.cs)
<!-- default file list end -->
# Building a mail application with the RichEditControl


<p>This example illustrates how the built-in document export functionality of the XtraRichEdit can be used to construct a simple application allowing you to send the document via email. A document, loaded into the RichEditControl, is sent in HTML email format.</p>
<p>To accomplish the task, we have to transform the document into the HTML formatted stream. Inline pictures will form a collection of <strong> linked resources</strong> (<strong>System.Net.Mail.LinkedResourceCollection</strong> ) for the email attachment. Common methods of the <strong>System.Net.Mail.MailMessage</strong> class are used to create a message. The message is sent with the help of the <strong>System.Net.Mail.SmtpClient</strong> class instance.</p>
<p>Let's elaborate a document export process further. To gain a control over RichEdit export, we construct a <strong>RichEditMailMessageExporter</strong> class, which implements the <strong><a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressOfficeServicesIUriProvidertopic">IUriProvider</a></strong> interface. This interface contains two methods -<a href="http://help.devexpress.com/#CoreLibraries/DevExpressOfficeServicesIUriProvider_CreateCssUritopic"> CreateCssUri</a> and <a href="http://help.devexpress.com/#CoreLibraries/DevExpressOfficeServicesIUriProvider_CreateImageUritopic">CreateImageUri</a>. We use default CSS handling, so the <strong>CreateCssUri</strong> method always returns null. The <strong>CreateImageUri</strong> method is used to transform each document image into an object of the helper class - the AttachmentInfo class instance. An instance of this class contains an image's name, type and the data stream. An image is identified by its name, so this method returns a CID (Content-ID) URL containing the image name, to include a link to the image in the message body.<br> The <strong>CreateHtmlView</strong> method of the RichEditMailMessageExporter gets the content of the RichEdit document using the <strong><a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSubDocument_GetHtmlTexttopic">GetHtmlText</a></strong> method, handles the <strong><a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_BeforeExporttopic">BeforeExport</a></strong> event to specify encoding and creates the <strong>System.Net.Mail.AlternateView</strong> object required for HTML email format. Note that the document's HTML code contains CID URIs constructed using the CreateImageUri method in place of images. Then a collection of <strong>AttachmentInfo</strong> objects, representing document images, is used to fill a collection of embedded resources for the message.<br> The <strong>Export</strong> method of the RichEditMailMessageExporter class calls the CreateHtmlView method to accomplish the major task, and adjusts the message parameters as required.<br> Now, when the main functionality is incorporated into the RichEditMailMessageExporter class, the code for creating and sending the message looks simple and straightforward. Create a message, fill in 'from' and 'to' fields, create an exporter and call its 'Export' method, create an smtp client instance, specify the E-mail account settings and call the 'Send' method to send a message.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=build-a-mail-application-with-the-richeditcontrol&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=build-a-mail-application-with-the-richeditcontrol&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
