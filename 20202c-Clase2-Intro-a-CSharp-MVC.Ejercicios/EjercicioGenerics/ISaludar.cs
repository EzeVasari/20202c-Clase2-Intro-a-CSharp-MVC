﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20202c_Clase2_Intro_a_CSharp_MVC.Ejercicios.EjercicioGenerics
{
    public interface ISaludar
    {
        string Nombre { get; set; }
        string Saludar();
    }
}
