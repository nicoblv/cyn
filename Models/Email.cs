﻿using MimeKit;
using MailKit.Net.Smtp;

namespace Invitacion.Models
{
    public class Email
    {
        public void EnviarEmail(string primero, string segundo, string tercero, string cuarto, string confirmacion, string mensaje, int cantidad)
        {
            try
            {
                var email = new MimeMessage();
                //string correo_origen = "MENSAJERIA@SANATORIOALEMAN.CL";
                string correo_origen = "nico_aims@outlook.com";
                string ip_servidor = "smtp.office365.com";
                int puerto = 587;
                string UserCorreo = correo_origen;
                //string PassCorreo = "Cuartel2021";
                string PassCorreo = "nhikolas123@";
                string correo_destino = "cata.sandovalf17@icloud.com";
                string correo_oculto = "nicoblv@icloud.com";

                string strSubject = "Invitación";
                string invitados = "";
                if (cantidad == 1)
                {
                    invitados = primero;
                }
                else if(cantidad == 2)
                {
                    invitados = primero + " - " + segundo;
                }
                else if(cantidad == 3)
                {
                    invitados = primero + " - " + segundo + " - " + tercero;
                }
                else if(cantidad == 4)
                {
                    invitados = primero + " - " + segundo + " - " + tercero + " - " + cuarto;
                }

                string strMensaje = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n    style=\"width:100%;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0\">\r\n\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta content=\"width=device-width, initial-scale=1\" name=\"viewport\">\r\n    <meta name=\"x-apple-disable-message-reformatting\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta content=\"telephone=no\" name=\"format-detection\">\r\n    <link href=\"https://fonts.googleapis.com/css?family=Open+Sans:400,400i,700,700i\" rel=\"stylesheet\"><!--<![endif]-->\r\n    <style type=\"text/css\">\r\n        #outlook a {\r\n            padding: 0;\r\n        }\r\n\r\n        .ExternalClass {\r\n            width: 100%;\r\n        }\r\n\r\n        .ExternalClass,\r\n        .ExternalClass p,\r\n        .ExternalClass span,\r\n        .ExternalClass font,\r\n        .ExternalClass td,\r\n        .ExternalClass div {\r\n            line-height: 100%;\r\n        }\r\n\r\n        .es-button {\r\n            mso-style-priority: 100 !important;\r\n            text-decoration: none !important;\r\n        }\r\n\r\n        a[x-apple-data-detectors] {\r\n            color: inherit !important;\r\n            text-decoration: none !important;\r\n            font-size: inherit !important;\r\n            font-family: inherit !important;\r\n            font-weight: inherit !important;\r\n            line-height: inherit !important;\r\n        }\r\n\r\n        .es-desk-hidden {\r\n            display: none;\r\n            float: left;\r\n            overflow: hidden;\r\n            width: 0;\r\n            max-height: 0;\r\n            line-height: 0;\r\n            mso-hide: all;\r\n        }\r\n\r\n        @media only screen and (max-width:600px) {\r\n\r\n            p,\r\n            ul li,\r\n            ol li,\r\n            a {\r\n                line-height: 150% !important\r\n            }\r\n\r\n            h1,\r\n            h2,\r\n            h3,\r\n            h1 a,\r\n            h2 a,\r\n            h3 a {\r\n                line-height: 120% !important\r\n            }\r\n\r\n            h1 {\r\n                font-size: 32px !important;\r\n                text-align: center\r\n            }\r\n\r\n            h2 {\r\n                font-size: 26px !important;\r\n                text-align: center\r\n            }\r\n\r\n            h3 {\r\n                font-size: 20px !important;\r\n                text-align: center\r\n            }\r\n\r\n            .es-header-body h1 a,\r\n            .es-content-body h1 a,\r\n            .es-footer-body h1 a {\r\n                font-size: 32px !important\r\n            }\r\n\r\n            .es-header-body h2 a,\r\n            .es-content-body h2 a,\r\n            .es-footer-body h2 a {\r\n                font-size: 26px !important\r\n            }\r\n\r\n            .es-header-body h3 a,\r\n            .es-content-body h3 a,\r\n            .es-footer-body h3 a {\r\n                font-size: 20px !important\r\n            }\r\n\r\n            .es-menu td a {\r\n                font-size: 16px !important\r\n            }\r\n\r\n            .es-header-body p,\r\n            .es-header-body ul li,\r\n            .es-header-body ol li,\r\n            .es-header-body a {\r\n                font-size: 16px !important\r\n            }\r\n\r\n            .es-content-body p,\r\n            .es-content-body ul li,\r\n            .es-content-body ol li,\r\n            .es-content-body a {\r\n                font-size: 16px !important\r\n            }\r\n\r\n            .es-footer-body p,\r\n            .es-footer-body ul li,\r\n            .es-footer-body ol li,\r\n            .es-footer-body a {\r\n                font-size: 16px !important\r\n            }\r\n\r\n            .es-infoblock p,\r\n            .es-infoblock ul li,\r\n            .es-infoblock ol li,\r\n            .es-infoblock a {\r\n                font-size: 12px !important\r\n            }\r\n\r\n            *[class=\"gmail-fix\"] {\r\n                display: none !important\r\n            }\r\n\r\n            .es-m-txt-c,\r\n            .es-m-txt-c h1,\r\n            .es-m-txt-c h2,\r\n            .es-m-txt-c h3 {\r\n                text-align: center !important\r\n            }\r\n\r\n            .es-m-txt-r,\r\n            .es-m-txt-r h1,\r\n            .es-m-txt-r h2,\r\n            .es-m-txt-r h3 {\r\n                text-align: right !important\r\n            }\r\n\r\n            .es-m-txt-l,\r\n            .es-m-txt-l h1,\r\n            .es-m-txt-l h2,\r\n            .es-m-txt-l h3 {\r\n                text-align: left !important\r\n            }\r\n\r\n            .es-m-txt-r img,\r\n            .es-m-txt-c img,\r\n            .es-m-txt-l img {\r\n                display: inline !important\r\n            }\r\n\r\n            .es-button-border {\r\n                display: inline-block !important\r\n            }\r\n\r\n            a.es-button,\r\n            button.es-button {\r\n                font-size: 16px !important;\r\n                display: inline-block !important;\r\n                padding: 15px 30px 15px 30px !important\r\n            }\r\n\r\n            .es-btn-fw {\r\n                border-width: 10px 0px !important;\r\n                text-align: center !important\r\n            }\r\n\r\n            .es-adaptive table,\r\n            .es-btn-fw,\r\n            .es-btn-fw-brdr,\r\n            .es-left,\r\n            .es-right {\r\n                width: 100% !important\r\n            }\r\n\r\n            .es-content table,\r\n            .es-header table,\r\n            .es-footer table,\r\n            .es-content,\r\n            .es-footer,\r\n            .es-header {\r\n                width: 100% !important;\r\n                max-width: 600px !important\r\n            }\r\n\r\n            .es-adapt-td {\r\n                display: block !important;\r\n                width: 100% !important\r\n            }\r\n\r\n            .adapt-img {\r\n                width: 100% !important;\r\n                height: auto !important\r\n            }\r\n\r\n            .es-m-p0 {\r\n                padding: 0px !important\r\n            }\r\n\r\n            .es-m-p0r {\r\n                padding-right: 0px !important\r\n            }\r\n\r\n            .es-m-p0l {\r\n                padding-left: 0px !important\r\n            }\r\n\r\n            .es-m-p0t {\r\n                padding-top: 0px !important\r\n            }\r\n\r\n            .es-m-p0b {\r\n                padding-bottom: 0 !important\r\n            }\r\n\r\n            .es-m-p20b {\r\n                padding-bottom: 20px !important\r\n            }\r\n\r\n            .es-mobile-hidden,\r\n            .es-hidden {\r\n                display: none !important\r\n            }\r\n\r\n            tr.es-desk-hidden,\r\n            td.es-desk-hidden,\r\n            table.es-desk-hidden {\r\n                width: auto !important;\r\n                overflow: visible !important;\r\n                float: none !important;\r\n                max-height: inherit !important;\r\n                line-height: inherit !important\r\n            }\r\n\r\n            tr.es-desk-hidden {\r\n                display: table-row !important\r\n            }\r\n\r\n            table.es-desk-hidden {\r\n                display: table !important\r\n            }\r\n\r\n            td.es-desk-menu-hidden {\r\n                display: table-cell !important\r\n            }\r\n\r\n            .es-menu td {\r\n                width: 1% !important\r\n            }\r\n\r\n            table.es-table-not-adapt,\r\n            .esd-block-html table {\r\n                width: auto !important\r\n            }\r\n\r\n            table.es-social {\r\n                display: inline-block !important\r\n            }\r\n\r\n            table.es-social td {\r\n                display: inline-block !important\r\n            }\r\n\r\n            .es-desk-hidden {\r\n                display: table-row !important;\r\n                width: auto !important;\r\n                overflow: visible !important;\r\n                max-height: inherit !important\r\n            }\r\n        }\r\n    </style>\r\n</head>\r\n\r\n<body style=\"width:600px;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif;padding:0;Margin:0\">\r\n    <div class=\"es-wrapper-color\" style=\"background-color:transparent\">\r\n        <table class=\"es-wrapper\" width=\"600px\" cellspacing=\"0\" cellpadding=\"0\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top;background-color:transparent\">\r\n            <tr style=\"border-collapse:collapse\">\r\n                <td valign=\"top\" style=\"padding:0;Margin:0\">\r\n                    <table class=\"es-content\" cellspacing=\"0\" cellpadding=\"0\" align=\"center\"\r\n                        style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%\">\r\n                        <tr style=\"border-collapse:collapse\">\r\n                            <td align=\"center\" style=\"padding:0;Margin:0\">\r\n                                <table class=\"es-content-body\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\"\r\n                                    align=\"center\"\r\n                                    style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px\">\r\n                                    \r\n                                    <tr style=\"border-collapse:collapse\">\r\n                                        <td align=\"left\"\r\n                                            style=\"padding:0;Margin:0;padding-left:35px;padding-right:35px\">\r\n                                            <table width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"\r\n                                                style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px\">\r\n                                                <tr style=\"border-collapse:collapse\">\r\n                                                    <td valign=\"top\" align=\"center\"\r\n                                                        style=\"padding:0;Margin:0;width:530px\">\r\n                                                        <table width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"\r\n                                                            role=\"presentation\"\r\n                                                            style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px\">\r\n                                                            <tr style=\"border-collapse:collapse\">\r\n                                                                <td align=\"left\" style=\"padding:10px;Margin:0\">\r\n                                                                    <table\r\n                                                                        style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;width:500px\"\r\nclass=\"cke_show_border\" cellspacing=\"1\"\r\ncellpadding=\"1\" border=\"0\" align=\"left\"\r\nrole=\"presentation\">\r\n<tr style=\"border-collapse:collapse\">\r\n                                                                            <td style=\"padding:5px 10px 5px 0;Margin:0\"\r\n                                                                                width=\"30%\" align=\"left\">\r\n<h4 style=\"Margin:0;line-height:120%;mso-line-height-rule:exactly;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif\">\r\nConfirmación</h4>\r\n</td>\r\n<td style=\"padding:5px 0;Margin:0\"\r\nwidth=\"70%\" align=\"left\">\r\n<p style=\"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif;line-height:24px;color:#333333;font-size:16px\">\r\n" + confirmacion + "</p>\r\n</td>\r\n</tr>\r\n<tr style=\"border-collapse:collapse\">\r\n<td style=\"padding:5px 10px 5px 0;Margin:0\"\r\nwidth=\"30%\" align=\"left\">\r\n<h4 style=\"Margin:0;line-height:120%;mso-line-height-rule:exactly;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif\">\r\nInvitados</h4>\r\n</td>\r\n<td style=\"padding:5px 0;Margin:0\"\r\nwidth=\"70%\" align=\"left\">\r\n<p style=\"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif;line-height:24px;color:#333333;font-size:16px\">\r\n" + invitados + "</p>\r\n</td>\r\n</tr>\r\n<tr style=\"border-collapse:collapse\">\r\n<td style=\"padding:5px 10px 5px 0;Margin:0\"\r\nwidth=\"30%\" align=\"left\">\r\n<h4 style=\"Margin:0;line-height:120%;mso-line-height-rule:exactly;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif\">\r\nMensaje</h4>\r\n</td>\r\n<td style=\"padding:5px 0;Margin:0\"\r\nwidth=\"70%\" align=\"left\">\r\n<p style=\"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif;line-height:24px;color:#333333;font-size:16px\">\r\n" + mensaje + "</p>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</table>\r\n</div>\r\n</body>\r\n</html>";

                //string strMensaje = "Invitados: " + primero + " - " + segundo + " - " + tercero + "\r\n\r\nConfirmación: " + confirmacion + "\r\n\r\nMensaje: " + mensaje;
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = strMensaje;

                email.From.Add(MailboxAddress.Parse(UserCorreo));
                email.To.Add(MailboxAddress.Parse(correo_destino));
                email.Bcc.Add(MailboxAddress.Parse(correo_oculto));
                email.Subject = strSubject;
                email.Body = bodyBuilder.ToMessageBody();

                using var smtp = new SmtpClient();

                smtp.Connect(ip_servidor, puerto, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(UserCorreo, PassCorreo);
                smtp.Send(email);
                smtp.Disconnect(true);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
