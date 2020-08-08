using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace restSharpSpecFlowNetCore.DesafioB2.Requests.Projects
{
    public class ProjectsRequest : RequestBase
    {
        //uri para requisição
        public ProjectsRequest()
        {
            requestService = "/api/rest/projects/";
            method = Method.POST;
        }

        //metodo e variaveis a ser enviadas
        public void SetJsonBody(
            //string id,
            string nameProject,
            string status,
            string label,
            string description,
            string filePath,
            string nameViewState,
            string labelViewState)
        {
            //Encontra o arquivo Json a ser usado para passagem de parametros
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Projects/BodyRawProjects.json", Encoding.UTF8);

            // Troca no arquivo/contrato json as variavel de acordo com os valores repassado pela metodo
            jsonBody = jsonBody.Replace("$nameProject", nameProject);
            jsonBody = jsonBody.Replace("$nameStatus", status);
            jsonBody = jsonBody.Replace("$nameLabel", label);
            jsonBody = jsonBody.Replace("$fildDescription", description);
            jsonBody = jsonBody.Replace("$filePath", filePath);
            jsonBody = jsonBody.Replace("$nameViewState", nameViewState);
            jsonBody = jsonBody.Replace("$labelViewState", labelViewState);
        }
    }
}
