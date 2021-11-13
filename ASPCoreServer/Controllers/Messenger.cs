﻿using Messenger_13._11._2021;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Messenger : ControllerBase
    {
        static List<Message> ListOfMessages = new List<Message>();

        // GET api/<Messenger>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string OutputString = "Not Found";
            if ((id < ListOfMessages.Count) && (id >= 0))
            {
                OutputString = JsonConvert.SerializeObject(ListOfMessages[id]);
            }
            Console.WriteLine(String.Format("Запрошено сообщение № {0} : {1}", id, OutputString));
            return OutputString;
        }

        // POST api/<Messenger>
        [HttpPost]
        public IActionResult SendMessage([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }
            ListOfMessages.Add(msg);
            Console.WriteLine(String.Format("Всего сообщений: {0}, посланное сообщение: {1}", ListOfMessages.Count, msg));
            //return NoContentResult();
            return new OkResult();
        }

    }
}
