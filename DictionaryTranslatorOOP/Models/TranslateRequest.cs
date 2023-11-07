using DictionaryTranslatorOOP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using Google.Cloud.Translation.V2;

namespace DictionaryTranslatorOOP
{
    public class TranslateRequest
    {
        private readonly TranslationClient _client;

        public TranslateRequest()
        {
            _client = TranslationClient.Create();
        }

        public string Text { get; set; }

        public string TranslateText(string text, string targetLanguage)
        {
            var response = _client.TranslateText(text, targetLanguage);
            return response.TranslatedText;
        }
    }

}