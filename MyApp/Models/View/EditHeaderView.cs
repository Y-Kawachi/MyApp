using MyApp.Models.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Models.View
{

    public class EditHeaderView
    {
        public Header Header { get; set; }

        public Dictionary<string, string> codes { get; set; }

    }
}