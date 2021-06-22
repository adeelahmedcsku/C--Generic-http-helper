using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers.HttpClientHelper
{
   public   class MediaTypeEnum
    {
        ///<summary>Atom feeds</summary>
            public static readonly  MediaTypeEnum ApplicationAtomXml = new MediaTypeEnum ("application/atom+xml","");

            ///<summary>Cascading Style Sheets; Defined in RFC 2318</summary>
            public static MediaTypeEnum TextCss = new MediaTypeEnum ("text/css", "");

        ///<summary>commands; subtype resident in Gecko browsers like Firefox 3.5</summary>
        public static readonly MediaTypeEnum TextCmd = new MediaTypeEnum ("text/cmd", "");

        ///<summary>Comma-separated values; Defined in RFC 4180</summary>
        public static readonly MediaTypeEnum TextCsv = new MediaTypeEnum ("text/csv","");

            ///<summary>deb (file format), a software package format used by the Debian project</summary>
            public static readonly MediaTypeEnum ApplicationXDeb = new MediaTypeEnum ("application/x-deb","");

            ///<summary>Defined in RFC 1847</summary>
            public static readonly MediaTypeEnum MultipartEncrypted = new MediaTypeEnum ("multipart/encrypted","");

            ///<summary>Defined in RFC 1847</summary>
            public static readonly MediaTypeEnum MultipartSigned = new MediaTypeEnum ("multipart/signed","");

            ///<summary>Defined in RFC 2616</summary>
            public static readonly MediaTypeEnum MessageHttp = new MediaTypeEnum ("message/http","");

            ///<summary>Defined in RFC 4735</summary>
            public static readonly MediaTypeEnum ModelExample = new MediaTypeEnum ("model/example","");

            ///<summary>device-independent document in DVI format</summary>
            public static readonly MediaTypeEnum ApplicationXDvi = new MediaTypeEnum ("application/x-dvi","");

            ///<summary>DTD files; Defined by RFC 3023</summary>
            public static readonly MediaTypeEnum ApplicationXmlDtd = new MediaTypeEnum ("application/xml-dtd","");

            ///<summary>ECMAScript/JavaScript; Defined in RFC 4329 (equivalent to application/ecmascript but with looser processing rules) It is not accepted in IE 8 or earlier - text/javascript is accepted but it is defined as obsolete in RFC 4329. The "type" attribute of the <script> tag in HTML5 is optional and in practice omitting the media type of JavaScript programs is the most interoperable solution since all browsers have always assumed the correct default even before HTML5.</summary>
            public static readonly MediaTypeEnum ApplicationJavascript = new MediaTypeEnum ("application/javascript","");

            ///<summary>ECMAScript/JavaScript; Defined in RFC 4329 (equivalent to application/javascript but with stricter processing rules)</summary>
            public static readonly MediaTypeEnum ApplicationEcmascript = new MediaTypeEnum ("application/ecmascript","");

            ///<summary>EDI EDIFACT data; Defined in RFC 1767</summary>
            public static readonly MediaTypeEnum ApplicationEdifact = new MediaTypeEnum ("application/EDIFACT","");

            ///<summary>EDI X12 data; Defined in RFC 1767</summary>
            public static readonly MediaTypeEnum ApplicationEdiX12 = new MediaTypeEnum ("application/EDI-X12","");

            ///<summary>Email; Defined in RFC 2045 and RFC 2046</summary>
            public static readonly MediaTypeEnum MessagePartial = new MediaTypeEnum ("message/partial","");

            ///<summary>Email; EML files, MIME files, MHT files, MHTML files; Defined in RFC 2045 and RFC 2046</summary>
            public static readonly MediaTypeEnum MessageRfc822 = new MediaTypeEnum ("message/rfc822","");

            ///<summary>Extensible Markup Language; Defined in RFC 3023</summary>
            public static readonly MediaTypeEnum TextXml = new MediaTypeEnum ("text/xml","");

            ///<summary>Extensible Markup Language; Defined in RFC 3023</summary>
            public static readonly MediaTypeEnum ApplicationXml = new MediaTypeEnum ("application/xml","");

            ///<summary>Flash video (FLV files)</summary>
            public static readonly MediaTypeEnum VideoXFlv = new MediaTypeEnum ("video/x-flv","");

            ///<summary>GIF image; Defined in RFC 2045 and RFC 2046</summary>
            public static readonly MediaTypeEnum ImageGif = new MediaTypeEnum ("image/gif","");

            ///<summary>GoogleWebToolkit data</summary>
            public static readonly MediaTypeEnum TextXGwtRpc = new MediaTypeEnum ("text/x-gwt-rpc","");

            ///<summary>Gzip</summary>
            public static readonly MediaTypeEnum ApplicationXGzip = new MediaTypeEnum ("application/x-gzip","");

            ///<summary>HTML; Defined in RFC 2854</summary>
            public static readonly MediaTypeEnum TextHtml = new MediaTypeEnum ("text/html","");

            ///<summary>ICO image; Registered[9]</summary>
            public static readonly MediaTypeEnum ImageVndMicrosoftIcon = new MediaTypeEnum ("image/vnd.microsoft.icon","");

            ///<summary>IGS files, IGES files; Defined in RFC 2077</summary>
            public static readonly MediaTypeEnum ModelIges = new MediaTypeEnum ("model/iges","");

            ///<summary>IMDN Instant Message Disposition Notification; Defined in RFC 5438</summary>
            public static readonly MediaTypeEnum MessageImdnXml = new MediaTypeEnum ("message/imdn+xml","");

            ///<summary>JavaScript Object Notation JSON; Defined in RFC 4627</summary>
            public static readonly MediaTypeEnum ApplicationJson = new MediaTypeEnum ("application/json","");

            ///<summary>JavaScript Object Notation (JSON) Patch; Defined in RFC 6902</summary>
            public static readonly MediaTypeEnum ApplicationJsonPatch = new MediaTypeEnum ("application/json-patch+json","");

            ///<summary>JavaScript - Defined in and obsoleted by RFC 4329 in order to discourage its usage in favor of application/javascript. However,text/javascript is allowed in HTML 4 and 5 and, unlike application/javascript, has cross-browser support. The "type" attribute of the <script> tag in HTML5 is optional and there is no need to use it at all since all browsers have always assumed the correct default (even in HTML 4 where it was required by the specification).</summary>
           
            public static readonly MediaTypeEnum TextJavascript = new MediaTypeEnum ("text/javascript","");

            ///<summary>JPEG JFIF image; Associated with Internet Explorer; Listed in ms775147(v=vs.85) - Progressive JPEG, initiated before global browser support for progressive JPEGs (Microsoft and Firefox).</summary>
            public static readonly MediaTypeEnum ImagePjpeg = new MediaTypeEnum ("image/pjpeg","");

            ///<summary>JPEG JFIF image; Defined in RFC 2045 and RFC 2046</summary>
            public static readonly MediaTypeEnum ImageJpeg = new MediaTypeEnum ("image/jpeg","");

            ///<summary>jQuery template data</summary>
            public static readonly MediaTypeEnum TextXJqueryTmpl = new MediaTypeEnum ("text/x-jquery-tmpl","");

            ///<summary>KML files (e.g. for Google Earth)</summary>
            public static readonly MediaTypeEnum ApplicationVndGoogleEarthKmlXml = new MediaTypeEnum ("application/vnd.google-earth.kml+xml","");

            ///<summary>LaTeX files</summary>
            public static readonly MediaTypeEnum ApplicationXLatex = new MediaTypeEnum ("application/x-latex","");

            ///<summary>Matroska open media format</summary>
            public static readonly MediaTypeEnum VideoXMatroska = new MediaTypeEnum ("video/x-matroska","");

            ///<summary>Microsoft Excel 2007 files</summary>
            public static readonly MediaTypeEnum ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet = new MediaTypeEnum ("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","");

            ///<summary>Microsoft Excel files</summary>
            public static readonly MediaTypeEnum ApplicationVndMsExcel = new MediaTypeEnum ("application/vnd.ms-excel","");

            ///<summary>Microsoft Powerpoint 2007 files</summary>
            public static readonly MediaTypeEnum ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation = new MediaTypeEnum ("application/vnd.openxmlformats-officedocument.presentationml.presentation","");

            ///<summary>Microsoft Powerpoint files</summary>
            public static readonly MediaTypeEnum ApplicationVndMsPowerpoint = new MediaTypeEnum ("application/vnd.ms-powerpoint","");

            ///<summary>Microsoft Word 2007 files</summary>
            public static readonly MediaTypeEnum ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument = new MediaTypeEnum ("application/vnd.openxmlformats-officedocument.wordprocessingml.document","");

            ///<summary>Microsoft Word files[15]</summary>
            public static readonly MediaTypeEnum ApplicationMsword = new MediaTypeEnum ("application/msword","");

            ///<summary>MIME Email; Defined in RFC 2045 and RFC 2046</summary>
            public static readonly MediaTypeEnum MultipartAlternative = new MediaTypeEnum ("multipart/alternative","");

            ///<summary>MIME Email; Defined in RFC 2045 and RFC 2046</summary>
            public static readonly MediaTypeEnum MultipartMixed = new MediaTypeEnum ("multipart/mixed","");

            ///<summary>MIME Email; Defined in RFC 2387 and used by MHTML (HTML mail)</summary>
            public static readonly MediaTypeEnum MultipartRelated = new MediaTypeEnum ("multipart/related","");

            ///<summary>MIME Webform; Defined in RFC 2388</summary>
            public static readonly MediaTypeEnum MultipartFormData = new MediaTypeEnum ("multipart/form-data","");

            /// <summary>Body contains a URL-encoded query readonly MediaTypeEnum as per RFC 1867</summary>
            public static readonly MediaTypeEnum ApplicationWwwFormUrlEncoded = new MediaTypeEnum ("application/x-www-form-urlencoded","");

            ///<summary>Mozilla XUL files</summary>
            public static readonly MediaTypeEnum ApplicationVndMozillaXulXml = new MediaTypeEnum ("application/vnd.mozilla.xul+xml","");

            ///<summary>MP3 or other MPEG audio; Defined in RFC 3003</summary>
            public static readonly MediaTypeEnum AudioMpeg = new MediaTypeEnum ("audio/mpeg","");

            ///<summary>MP4 audio</summary>
            public static readonly MediaTypeEnum AudioMp4 = new MediaTypeEnum ("audio/mp4","");

            ///<summary>MP4 video; Defined in RFC 4337</summary>
            public static readonly MediaTypeEnum VideoMp4 = new MediaTypeEnum ("video/mp4","");

            ///<summary>MPEG-1 video with multiplexed audio; Defined in RFC 2045 and RFC 2046</summary>
            public static readonly MediaTypeEnum VideoMpeg = new MediaTypeEnum ("video/mpeg","");

            ///<summary>MSH files, MESH files; Defined in RFC 2077, SILO files</summary>
            public static readonly MediaTypeEnum ModelMesh = new MediaTypeEnum ("model/mesh","");

            ///<summary>mulaw audio at 8 kHz, 1 channel; Defined in RFC 2046</summary>
            public static readonly MediaTypeEnum AudioBasic = new MediaTypeEnum ("audio/basic","");

            ///<summary>Ogg Theora or other video (with audio); Defined in RFC 5334</summary>
            public static readonly MediaTypeEnum VideoOgg = new MediaTypeEnum ("video/ogg","");

            ///<summary>Ogg Vorbis, Speex, Flac and other audio; Defined in RFC 5334</summary>
            public static readonly MediaTypeEnum AudioOgg = new MediaTypeEnum ("audio/ogg","");

            ///<summary>Ogg, a multimedia bitstream container format; Defined in RFC 5334</summary>
            public static readonly MediaTypeEnum ApplicationOgg = new MediaTypeEnum ("application/ogg","");

            ///<summary>OP</summary>
            public static readonly MediaTypeEnum ApplicationXopXml = new MediaTypeEnum ("application/xop+xml","");

            ///<summary>OpenDocument Graphics; Registered[14]</summary>
            public static readonly MediaTypeEnum ApplicationVndOasisOpendocumentGraphics = new MediaTypeEnum ("application/vnd.oasis.opendocument.graphics","");

            ///<summary>OpenDocument Presentation; Registered[13]</summary>
            public static readonly MediaTypeEnum ApplicationVndOasisOpendocumentPresentation = new MediaTypeEnum ("application/vnd.oasis.opendocument.presentation","");

            ///<summary>OpenDocument Spreadsheet; Registered[12]</summary>
            public static readonly MediaTypeEnum ApplicationVndOasisOpendocumentSpreadsheet = new MediaTypeEnum ("application/vnd.oasis.opendocument.spreadsheet","");

            ///<summary>OpenDocument Text; Registered[11]</summary>
            public static readonly MediaTypeEnum ApplicationVndOasisOpendocumentText = new MediaTypeEnum ("application/vnd.oasis.opendocument.text","");

            ///<summary>p12 files</summary>
            public static readonly MediaTypeEnum ApplicationXPkcs12 = new MediaTypeEnum ("application/x-pkcs12","");

            ///<summary>p7b and spc files</summary>
            public static readonly MediaTypeEnum ApplicationXPkcs7Certificates = new MediaTypeEnum ("application/x-pkcs7-certificates","");

            ///<summary>p7c files</summary>
            public static readonly MediaTypeEnum ApplicationXPkcs7Mime = new MediaTypeEnum ("application/x-pkcs7-mime","");

            ///<summary>p7r files</summary>
            public static readonly MediaTypeEnum ApplicationXPkcs7Certreqresp = new MediaTypeEnum ("application/x-pkcs7-certreqresp","");

            ///<summary>p7s files</summary>
            public static readonly MediaTypeEnum ApplicationXPkcs7Signature = new MediaTypeEnum ("application/x-pkcs7-signature","");

            ///<summary>Portable Document Format, PDF has been in use for document exchange on the Internet since 1993; Defined in RFC 3778</summary>
            public static readonly MediaTypeEnum ApplicationPdf = new MediaTypeEnum ("application/pdf","");

            ///<summary>Portable Network Graphics; Registered,[8] Defined in RFC 2083</summary>
            public static readonly MediaTypeEnum ImagePng = new MediaTypeEnum ("image/png","");

            ///<summary>PostScript; Defined in RFC 2046</summary>
            public static readonly MediaTypeEnum ApplicationPostscript = new MediaTypeEnum ("application/postscript","");

            ///<summary>QuickTime video; Registered[10]</summary>
            public static readonly MediaTypeEnum VideoQuicktime = new MediaTypeEnum ("video/quicktime","");

            ///<summary>RAR archive files</summary>
            public static readonly MediaTypeEnum ApplicationXRarCompressed = new MediaTypeEnum ("application/x-rar-compressed","");

            ///<summary>RealAudio; Documented in RealPlayer Customer Support Answer 2559</summary>
            public static readonly MediaTypeEnum AudioVndRnRealaudio = new MediaTypeEnum ("audio/vnd.rn-realaudio","");

            ///<summary>Resource Description Framework; Defined by RFC 3870</summary>
            public static readonly MediaTypeEnum ApplicationRdfXml = new MediaTypeEnum ("application/rdf+xml","");

            ///<summary>RSS feeds</summary>
            public static readonly MediaTypeEnum ApplicationRssXml = new MediaTypeEnum ("application/rss+xml","");

            ///<summary>SOAP; Defined by RFC 3902</summary>
            public static readonly MediaTypeEnum ApplicationSoapXml = new MediaTypeEnum ("application/soap+xml","");

            ///<summary>StuffIt archive files</summary>
            public static readonly MediaTypeEnum ApplicationXStuffit = new MediaTypeEnum ("application/x-stuffit","");

            ///<summary>SVG vector image; Defined in SVG Tiny 1.2 Specification Appendix M</summary>
            public static readonly MediaTypeEnum ImageSvgXml = new MediaTypeEnum ("image/svg+xml","");

            ///<summary>Tag Image File Format (only for Baseline TIFF); Defined in RFC 3302</summary>
            public static readonly MediaTypeEnum ImageTiff = new MediaTypeEnum ("image/tiff","");

            ///<summary>Tarball files</summary>
            public static readonly MediaTypeEnum ApplicationXTar = new MediaTypeEnum ("application/x-tar","");

            ///<summary>Textual data; Defined in RFC 2046 and RFC 3676</summary>
            public static readonly MediaTypeEnum TextPlain = new MediaTypeEnum ("text/plain","");

            ///<summary>TrueType Font No registered MIME type, but this is the most commonly used</summary>
            public static readonly MediaTypeEnum ApplicationXFontTtf = new MediaTypeEnum ("application/x-font-ttf","");

            ///<summary>vCard (contact information); Defined in RFC 6350</summary>
            public static readonly MediaTypeEnum TextVcard = new MediaTypeEnum ("text/vcard","");

            ///<summary>Vorbis encoded audio; Defined in RFC 5215</summary>
            public static readonly MediaTypeEnum AudioVorbis = new MediaTypeEnum ("audio/vorbis","");

            ///<summary>WAV audio; Defined in RFC 2361</summary>
            public static readonly MediaTypeEnum AudioVndWave = new MediaTypeEnum ("audio/vnd.wave","");

            ///<summary>Web Open Font Format; (candidate recommendation; use application/x-font-woff until standard is official)</summary>
            public static readonly MediaTypeEnum ApplicationFontWoff = new MediaTypeEnum ("application/font-woff","");

            ///<summary>WebM Matroska-based open media format</summary>
            public static readonly MediaTypeEnum VideoWebm = new MediaTypeEnum ("video/webm","");

            ///<summary>WebM open media format</summary>
            public static readonly MediaTypeEnum AudioWebm = new MediaTypeEnum ("audio/webm","");

            ///<summary>Windows Media Audio Redirector; Documented in Microsoft help page</summary>
            public static readonly MediaTypeEnum AudioXMsWax = new MediaTypeEnum ("audio/x-ms-wax","");

            ///<summary>Windows Media Audio; Documented in Microsoft KB 288102</summary>
            public static readonly MediaTypeEnum AudioXMsWma = new MediaTypeEnum ("audio/x-ms-wma","");

            ///<summary>Windows Media Video; Documented in Microsoft KB 288102</summary>
            public static readonly MediaTypeEnum VideoXMsWmv = new MediaTypeEnum ("video/x-ms-wmv","");

            ///<summary>WRL files, VRML files; Defined in RFC 2077</summary>
            public static readonly MediaTypeEnum ModelVrml = new MediaTypeEnum ("model/vrml","");

            ///<summary>X3D ISO standard for representing 3D computer graphics, X3D XML files</summary>
            public static readonly MediaTypeEnum ModelX3DXml = new MediaTypeEnum ("model/x3d+xml","");

            ///<summary>X3D ISO standard for representing 3D computer graphics, X3DB binary files</summary>
            public static readonly MediaTypeEnum ModelX3DBinary = new MediaTypeEnum ("model/x3d+binary","");

            ///<summary>X3D ISO standard for representing 3D computer graphics, X3DV VRML files</summary>
            public static readonly MediaTypeEnum ModelX3DVrml = new MediaTypeEnum ("model/x3d+vrml","");

            ///<summary>XHTML; Defined by RFC 3236</summary>
            public static readonly MediaTypeEnum ApplicationXhtmlXml = new MediaTypeEnum ("application/xhtml+xml","");

            ///<summary>ZIP archive files; Registered[7]</summary>
            public static readonly MediaTypeEnum ApplicationZip = new MediaTypeEnum ("application/zip", "");


      
        private MediaTypeEnum(String code, String description)
        {
            this.code = code;
            this.description = description;
        }


        public static IEnumerable<MediaTypeEnum> Values
        {
            get
            {
                yield return ApplicationAtomXml;
                yield return TextCss;
                yield return TextCmd;
                yield return TextCsv;
                yield return ApplicationXDeb;
                yield return MultipartEncrypted;
                yield return MultipartSigned;
                yield return MessageHttp;
                yield return ModelExample;
                yield return ApplicationXDvi;
                yield return ApplicationXmlDtd;
                yield return ApplicationJavascript;

                yield return ApplicationEcmascript;
                yield return ApplicationEdifact;
                yield return ApplicationEdiX12;
                yield return MessagePartial;
                yield return MessageRfc822;
                yield return TextXml;
                yield return ApplicationXml;
                yield return VideoXFlv;
                yield return ImageGif;
                yield return TextXGwtRpc;
                yield return ApplicationXGzip;
                yield return TextHtml;

                yield return ImageVndMicrosoftIcon;
                yield return ModelIges;
                yield return MessageImdnXml;
                yield return ApplicationJson;
                yield return ApplicationJsonPatch;
                yield return TextJavascript;
                yield return ImagePjpeg;
                yield return ImageJpeg;
                yield return TextXJqueryTmpl;
                yield return ApplicationVndGoogleEarthKmlXml;
                yield return ApplicationXLatex;
                yield return VideoXMatroska;


                yield return ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet;
                yield return ApplicationVndMsExcel;
                yield return ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation;
                yield return ApplicationVndMsPowerpoint;
                yield return ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument;
                yield return ApplicationMsword;
                yield return MultipartAlternative;
                yield return MultipartMixed;
                yield return MultipartRelated;
                yield return MultipartFormData;
                yield return ApplicationWwwFormUrlEncoded;
                yield return ApplicationVndMozillaXulXml;


                yield return AudioMpeg;
                yield return AudioMp4;
                yield return VideoMp4;
                yield return VideoMpeg;
                yield return ModelMesh;
                yield return AudioBasic;
                yield return VideoOgg;
                yield return AudioOgg;
                yield return ApplicationOgg;
                yield return ApplicationXopXml;
                yield return ApplicationVndOasisOpendocumentGraphics;
                yield return ApplicationVndOasisOpendocumentPresentation;



                yield return ApplicationVndOasisOpendocumentSpreadsheet;
                yield return ApplicationVndOasisOpendocumentText;
                yield return ApplicationXPkcs12;
                yield return ApplicationXPkcs7Certificates;
                yield return ApplicationXPkcs7Certreqresp;
                yield return ApplicationXPkcs7Signature;
                yield return ApplicationPdf;
                yield return ImagePng;
                yield return ApplicationPostscript;
                yield return VideoQuicktime;
                yield return ApplicationXRarCompressed;
                yield return AudioVndRnRealaudio;


                yield return ApplicationRdfXml;
                yield return ApplicationRssXml;
                yield return ApplicationSoapXml;
                yield return ApplicationXStuffit;
                yield return ImageSvgXml;
                yield return ImageTiff;
                yield return ApplicationXTar;
                yield return TextPlain;
                yield return ApplicationXFontTtf;
                yield return TextVcard;
                yield return AudioVorbis;
                yield return AudioVndWave;

                yield return ApplicationFontWoff;
                yield return VideoWebm;
                yield return AudioWebm;
                yield return AudioXMsWax;
                yield return AudioXMsWma;
                yield return VideoXMsWmv;
                yield return ModelVrml;
                yield return ModelX3DXml;
                yield return ModelX3DBinary;
                yield return ModelX3DVrml;
                yield return ApplicationXhtmlXml;
                yield return ApplicationZip;

            }
        }

        public static MediaTypeEnum GetByDescription(String description)
        {
            foreach (MediaTypeEnum media in Values)
            {
                if (media.description.Equals(description))
                {
                    return media;
                }
            }
            return null;
        }

        private String code;

        private String description;

        public String Code
        {
            get { return code; }
        }

        public String Description
        {
            get { return description; }
        }
    }
}
