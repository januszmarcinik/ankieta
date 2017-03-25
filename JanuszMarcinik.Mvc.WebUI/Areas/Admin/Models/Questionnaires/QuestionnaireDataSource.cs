﻿using JanuszMarcinik.Mvc.Domain.Application.DataSource;
using System.Collections.Generic;
using System.Linq;

namespace JanuszMarcinik.Mvc.WebUI.Areas.Admin.Models.Questionnaires
{
    public class QuestionnaireDataSource : DataSource<QuestionnaireViewModel>
    {
        public QuestionnaireDataSource() : base(new QuestionnaireViewModel()) { }

        public List<QuestionnaireViewModel> Questionnaires { get; set; }

        public override void SetActions()
        {
            base.PrepareData(this.Questionnaires.OrderBy(x => x.OrderNumber));

            foreach (var row in this.Data)
            {
                row.ListText = "Pytania";
                row.ListAction = MVC.Admin.Questions.List(row.PrimaryKeyId);
                row.EditAction = MVC.Admin.Questionnaires.Edit(row.PrimaryKeyId);
                row.DeleteAction = MVC.Admin.Questionnaires.Delete(row.PrimaryKeyId);
            }

            this.AddAction = MVC.Admin.Questionnaires.Create();
            this.BackAction = MVC.Admin.Configuration.Index();
            this.Title = "Ankiety";
        }
    }
}