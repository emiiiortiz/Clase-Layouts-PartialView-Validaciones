﻿using Clase_Layouts_PartialView_Validaciones.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Clase_Layouts_PartialView_Validaciones.Controllers
{
    public class UsuarioController : Controller
    {
        static List<Usuario> _listaUsuarios { get; set; } = new List<Usuario>();
        public IActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Nuevo(Models.Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _listaUsuarios.Add(usuario);
                return RedirectToAction(nameof(Lista));
            }
            return View(usuario);
        }
        public IActionResult Lista()
        {
            return View(_listaUsuarios);
        }
    }
}
