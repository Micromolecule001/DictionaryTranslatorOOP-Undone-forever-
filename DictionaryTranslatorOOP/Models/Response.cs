using DictionaryTranslatorOOP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;


namespace DictionaryTranslatorOOP
{
    public class Response
    {
        public int ResponseId { get; set; }
        public string WordTranslation { get; set; }
        public DateTime ReqDate { get; set; }
    }

}