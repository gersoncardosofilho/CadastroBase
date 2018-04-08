using FluentValidation.Attributes;
using MySampleCadastroProject.Domain.Customers.Enums;
using MySampleCadastroProject.Domain.Customers.Validations;
using System;

namespace MySampleCadastroProject.Domain.Customers.VOs
{
    [Validator(typeof(DocumentModelValidator))]
    public class Document
    {
        public Document(DateTime dataExpedicao, DocumentType documentType, string documentNumber)
        {
            DataExpedicao = dataExpedicao;
            DocumentType = documentType;
            DocumentNumber = documentNumber;
        }

        public Document()
        {

        }

        public DateTime DataExpedicao { get; private set; }
        public DocumentType DocumentType { get; set; }
        public string DocumentNumber { get; set; }


    }
}
