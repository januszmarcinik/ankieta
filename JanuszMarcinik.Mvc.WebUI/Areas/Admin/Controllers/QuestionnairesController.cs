﻿using AutoMapper;
using JanuszMarcinik.Mvc.Domain.Application.Entities.Questionnaires;
using JanuszMarcinik.Mvc.Domain.Application.Services.Questionnaires;
using JanuszMarcinik.Mvc.WebUI.Areas.Admin.Models.Questionnaires;
using System.Collections.Generic;
using System.Web.Mvc;

namespace JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Moderator")]
    public partial class QuestionnairesController : Controller
    {
        #region QuestionnairesController
        private QuestionnaireService _questionnaireService;

        public QuestionnairesController(QuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }
        #endregion

        #region List()
        public virtual ActionResult List()
        {
            var questionnaires = _questionnaireService.GetList();
            var model = new QuestionnaireDataSource();
            model.Questionnaires = Mapper.Map<List<QuestionnaireViewModel>>(questionnaires);
            model.SetActions();

            return View(MVC.Shared.Views._Grid, model.GetGridModel());
        }
        #endregion

        #region Create()
        public virtual ActionResult Create()
        {
            var model = new QuestionnaireViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create(QuestionnaireViewModel model)
        {
            if (ModelState.IsValid)
            {
                var questionnaire = new Questionnaire()
                {
                    OrderNumber = model.OrderNumber,
                    Name = model.Name,
                    Active = model.Active,
                    EditDisable = model.EditDisable
                };

                _questionnaireService.Create(questionnaire);

                return RedirectToAction(MVC.Admin.Questionnaires.List());
            }

            return View(model);
        }
        #endregion

        #region Edit
        public virtual ActionResult Edit(long id)
        {
            var questionnaire = _questionnaireService.GetById(id);
            var model = Mapper.Map<QuestionnaireViewModel>(questionnaire);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(QuestionnaireViewModel model)
        {
            if (ModelState.IsValid)
            {
                var questionnaire = _questionnaireService.GetById(model.QuestionnaireId);
                questionnaire.OrderNumber = model.OrderNumber;
                questionnaire.Name = model.Name;
                questionnaire.Active = model.Active;
                questionnaire.EditDisable = model.EditDisable;

                _questionnaireService.Update(questionnaire);

                return RedirectToAction(MVC.Admin.Questionnaires.List());
            }
            return View(model);
        }
        #endregion

        #region Delete()
        public virtual ActionResult Delete(long id)
        {
            var questionnaire = _questionnaireService.GetById(id);
            var model = Mapper.Map<QuestionnaireViewModel>(questionnaire);

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual ActionResult DeleteConfirmed(long id)
        {
            _questionnaireService.Delete(id);

            return RedirectToAction(MVC.Admin.Questionnaires.List());
        }
        #endregion
    }
}