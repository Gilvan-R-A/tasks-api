using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_C__API.Models
{
    public class Tarefa
    {
       public int Id { get; set; } 
       public string Titulo { get; set; }
       public DateTime Data { get; set; }
       public EnumStatusTarefa Status { get; set; }
    }
}