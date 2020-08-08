using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Helpers;
using restSharpSpecFlowNetCore.DesafioB2.Requests.Projects;
using RestSharpSpecFlowNetCoreTemplate.Helpers;
using TechTalk.SpecFlow;

namespace restSharpSpecFlowNetCore.DesafioB2.StepDefinitions
{
    [Binding]
    public class ProjetosStepsDefinitions
    {
        ProjectsRequest projectsRequest;
        IRestResponse<dynamic> response;

        private readonly SharedData sharedData;
        public ProjetosStepsDefinitions(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        #region parametros
        string id = "1";
        string name = "API Projects AUT " + GeneralHelpers.GenerateRandomNumber(3);
        string idStatus = "10";
        string nameStatus = "development";
        string labelStatus = "development";
        string description = "Desafio Teste de API";
        string filePath = "/tmp/";
        string nameViewState = "public";
        string labelViewState = "public";
        #endregion

        [Given(@"que envio um novo projeto")]
        public void DadoQueEnvioUmNovoProjeto()
        {
            
            projectsRequest = new ProjectsRequest();

            projectsRequest.SetJsonBody(name, nameStatus, labelStatus, description, filePath, nameViewState, labelViewState);

            response = projectsRequest.ExecuteRequest();

        }

        [StepDefinition(@"deve ser criando com sucesso")]
        public void ThenRequisicaoDeveSerRealizadaComSucesso()
        {
            string statusCodeEsperado = "Created";
            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}
