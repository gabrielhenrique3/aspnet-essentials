
using Microsoft.AspNetCore.Mvc;

namespace GerenciaTarefa.Controllers;



public class TarefaController:Controller{
//view = Página web (site)
//Funções

public IActionResult Index(){

    ViewData["Cabecalho"] = "Tarefa Diária";
    ViewData["Titulo"] = "Planejamento Aula Senai";
    ViewData["Descricao"] = "Criar nova PEUC";
    return View();

}

}