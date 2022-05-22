using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Compiler_project.Models;
using System.Collections;
using System.Diagnostics;

namespace Compiler_project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Editor()
        {
            return View();
        }


        [HttpPost]
        [ActionName("Editor")]
        public ActionResult EditorPost(string input_code, string btn, string fileContent, string filename, string removeFile)
        {
            if (removeFile == "Remove File")
            {
                fileContent = null;
                Session["fileContent"] = null;
                filename = null;
            }
            string input = "";

            if (input_code != "")
            {
                input = input_code;
            }

            if (fileContent != null && fileContent != "")
            {
                Session["fileContent"] = fileContent;
                input = (string)Session["fileContent"];
            }

            ViewBag.code = input_code;
            ViewBag.filename = filename;


            Session["CurrentCode"] = input;
            string currentCode = (string)(Session["CurrentCode"]);
            string pastCode = (string)(Session["PastCode"]);
            if (!currentCode.Equals(pastCode))
            {
                Session["isScanned"] = false;
            }
            if (input != "")
            {
                switch (btn)
                {
                    case "scan":

                        Scan(input);

                        return View();
                    case "parse":
                        Parse(input);

                        return View();
                    case "comment":
                        return View();
                    case "uncomment":
                        return View();



                }
            }

            return View();
        }

        private void Parse(string input)
        {
            ArrayList parseToView = new ArrayList();

            if ((Boolean)Session["isScanned"] == true)
            {
                LanguageParser parser = new LanguageParser(input);
                for (int i = 0; i < parser.parserOutput.Count; i++)
                {
                    string outputLine = (string)parser.parserOutput[i];
                    parseToView.Add(outputLine);
                }

            }
            else
            {
                parseToView.Add("Scanner Should Working first before the Parser");
            }
            ViewBag.vb = parseToView;
        }

        private void Scan(string input)
        {
            LanguageScanner scanner = new LanguageScanner(input);
            ArrayList tokensWithLineNumberToView = new ArrayList();
            for (int i = 0; i < scanner.tokensWithLineNumber.Count; i++)
            {
                TokenWithLineNumber tokenWithLineNumber = (TokenWithLineNumber)scanner.tokensWithLineNumber[i];
                int lineNumber = tokenWithLineNumber.lineNumber;
                string tokenName = tokenWithLineNumber.token.tokenName;
                string tokenValue = tokenWithLineNumber.token.tokenValue;
                tokensWithLineNumberToView.Add("Line : " + lineNumber + "\t\tToken Text: " + tokenName + "\t\t\t\t\tToken Type: " + tokenValue);
            }
            if (tokensWithLineNumberToView.Count != 0)
            {
                tokensWithLineNumberToView.Add("Total NO of errors: " + scanner.total_number_of_errors);
            }
            ViewBag.vb = tokensWithLineNumberToView;
            Session["isScanned"] = true;
            Session["PastCode"] = input;
        }


    }
}