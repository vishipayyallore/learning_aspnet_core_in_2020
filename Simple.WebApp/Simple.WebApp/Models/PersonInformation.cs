using System;

namespace Simple.WebApp.Models
{

    public class PersonInformation
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IsolationType IsoType { get; set; }
    }

}
