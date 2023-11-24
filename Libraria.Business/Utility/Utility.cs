using DinkToPdf;
using Libraria.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace Libraria.Business.Utility
{
    public static class Utility
    {
        public static void GenerateBarcode(string lexuesId)
        {
            try
            {
               

                        //The Image is finally converted to Base64 string.
              
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static string BuilString(Lexues lexues)
        {
            try
            {
                var sb = new StringBuilder();
                string barCode = @"C:\Users\User\source\repos\Libraria\Libraria\Documents\BarCodes\barCode01.png";
                var profilePhoto = Path.Combine(lexues.FotoProfiliURl, lexues.Foto);
                sb.Append(@"
                    <!DOCTYPE html>
                    <html>
                    <head>
                    <meta name='viewport' content='width=device-width, initial-scale=1'>
                    <style>
                    * {
                      box-sizing: border-box;
                    }
                    .card {
                      box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
                      transition: 0.3s;
                      border-radius: 5px;
                    }

                    /* Create two equal columns that floats next to each other */
                    .column {
                      float: left;
                      width: 50%;
                      height: 300px; /* Should be removed. Only for demonstration */
                    }

                    /* Clear floats after the columns */
                    .row:after {
                      content: '';
                      display: table;
                      clear: both;
                    }
                  
                    img
                    {
                    max-width : 200px;
                    }
                    .details{
                        border-left:3px solid #ded4da;
                    }
                    .container
                    {
                        margin : 5px;
                        padding : 10px;
                        height : 370px;
                        background-image: url('C:\Users\User\source\repos\Libraria\Libraria\Documents\LiberFoto\backKarte.jpg');
                    }
                    body
                    {
                        font-family: 'Lucida Console', 'Courier New', monospace;
                        margin : 5px;
                        height : auto;
                        background-image: url('C:\Users\User\source\repos\Libraria\Libraria\Documents\LiberFoto\backKarte.jpg');


                    }
                    </style>
                    </head>
                    <body>
                    <div class = 'container card'>
                    <br>
                    <h4>Karte Anetaresimi</h>
                    <div class='row'>
                      <div class='column' >
                      <br>
                       <div class = 'row'>
                       <img src=' " + profilePhoto + @"' alt='' class=''>
                        </div>
                        <div class = 'row'>
                       <img src=' " + barCode + @"' alt='' class='img-rounded'>
                        </div>
                      </div>
                      <div class='column' >
                             <p> Id :" + lexues.NmrId + @"</p>
                             <p> Emri :" + lexues.Emri + @"</p>
                             <p> Mbiemri :" + lexues.Mbiemri + @"</p>
                             <p> Data e Lindjes :" + lexues.Datelindja.Value.Date.ToShortDateString() + @"</p>
                             <p> Data e Regjistrimit :" + lexues.DataRegj.Date.ToShortDateString() + @"</p>
                             <p> Data e Skadimit :" + lexues.DataSkadimitTeKartes.Value.Date.ToShortDateString() + @"</p>

                      </div>
                    </div>
                    </div>
                    </body>
                    </html>"

                    //lexues.Datelindja.Value.Date.ToShortDateString().ToString(),
                    //lexues.DataRegj.Date.ToShortDateString().ToString()
                    ) ;
              
                return sb.ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
