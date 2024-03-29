﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSystem.Data.Models
{
    public class CanalEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<VariableParameterMaterialCanalEntity>? VariableParameterMaterialCanal { get; set; }
        public ICollection<ParameterCanalEntity>? ParameterCanal { get; set; }
    }
}
