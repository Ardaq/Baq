using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baq_Sozdik.Classes
{
    class HtmlHelper
    {
        public static String bootcss = "bootstrap.css";
        public static int id = 0;

        #region head

        public static String head = "<!DOCTYPE html><html><head><meta charset=\"utf-8\"><title>";

         public static String headtitle = "</title><link href=\"css/bootstrap.css\" rel=\"stylesheet\"><script src=\"js/jquery.min.js\"></script><script src=\"js/bootstrap.min.js\"></script></head>";

        #region body

        public static String bodyhead = "<body";

        #region container

        public static String containerhead = "<div class=\"container\">";

        #region h1

        public static String bodyheadh1 = "<h1><span class=\"glyphicon glyphicon-book\" style=\"color: rgb(105, 195, 60); font-size: 28px;\"> ";
        public static String bodyendh1 = "</span></h1>";

        #endregion h1

        #region dictionarycontainer

        public static String dictcontainerhead = "<div class=\"container\">";

        #region wordtabs

        public static String wordtabshead = "<div ><button type=\"button\" class=\"btn btn-primary btn-lg\" style=\"text-shadow: black 5px 3px 3px;\"><span class=\"glyphicon glyphicon-bookmark\">";
        public static String wordtabsend = "</span></button></div></br>";

        #endregion wordtabs

        #region definitions

        public static String definitionhead = "<div class=\"container\"><div class=\"panel-group\" id=\"accordion\"><div class=\"panel panel-default\">";

        #region definitionpanels

        public static String definitionpanelshead = "<div class=\"panel-heading\">";

        #region definitionpanelsh4

        public static String definitionpanelsh4head = "<h4 class=\"panel-title \">";
        public static String definitionpanelsh4ahead = "<a data-toggle=\"collapse\" data-parent=\"#accordion\" href=\"#";
        public static String definitionpanelsh4ahrefend = "\">";
        public static String definitionpanelsh4abadgehead = "<span class=\"badge\">";
        public static String definitionpanelsh4abadgeend = "</span>";
        public static String definitionpanelsh4aspanhead = "<span style=\"margin-left: 30px;\">";
        public static String definitionpanelsh4aspanend = "</span>";
        public static String definitionpanelsh4aend = "</a>";
        public static String definitionpanelsh4end = "</h4>";

        #endregion definitionpanelsh4

        public static String definitionpanelsend = "</div>";

        #endregion definitionpanels

        #region definitionpanelcollapse

        public static String defcollapsehead = "<div id=\"";
        public static String defcollapseheadin = "\" class=\"panel-collapse collapse in\">";

        #region definitionspanel-body

        public static String definitionbodyhead = "<div class=\"panel-body\">";

        #region definitionspanel-body-div

        public static String definitionbodydivhead = "<div>";

        #region definitionspanel-body-div-relation

        public static String divrelationhead = "<span class=\"glyphicon glyphicon-leaf\" style=\"color: rgb(255, 140, 60); font-size: 20px;\">";
        public static String divrelationend = "</span>";
        public static String divrelationwhead = "<span class=\"glyphicon glyphicon-play\" style=\"color: rgb(68, 142, 182);\">";
        public static String divrelationwend = "<span style=\"color: rgb(255, 255, 255); font-size: 20px;\">...</span></span>";

        #endregion definitionspanel-body-div-relation

        #region definitionspanel-body-div-catetory

        public static String divcatetoryhead = "<span class=\"glyphicon glyphicon-list\" style=\"color: rgb(38, 174, 42); font-size: 20px;\">";
        public static String divcatetoryend = "<span style=\"color: rgb(255, 255, 255); font-size: 20px;\">...</span></span>";

        #endregion definitionspanel-body-div-catetory

        #region definitionspanel-body-div-languages

        public static String divlanguageshead = "<span class=\"glyphicon glyphicon-globe\" style=\"color: rgb(70, 25, 108); font-size: 20px;\">";
        public static String divlanguagesend = "</span>";

        #endregion definitionspanel-body-div-languages

        public static String definitionbodydivend = "<p></p></div>";

        #endregion definitionspanel-body-div

        #region example

        public static String examplepanelhead = "<div class=\"panel panel-primary\">";
        public static String example = Baq_Sozdik.Properties.Resources.DivClassPanelHeadingH3ClassPanelTitleМысалH3Div;
        public static String examplebodyhead = "<div class=\"panel-body\">";
        public static String examplebodyend = "</div>";
        public static String examplepanelend = "</div>";

        #endregion example

        public static String definitionbodyend = "</div>";

        #endregion definitionspanel-body

        public static String defcollapseend = "</div>";

        #endregion definitionpanelcollapse

        public static String definitionend = "</div></div></div>";

        #endregion definitions

        public static String dictcontainerend = "</div>";

        #endregion dictionarycontainer

        #region worning

        public static String worning = Baq_Sozdik.Properties.Resources.DivClassContainerAlertAlertWarningStrongЕскертуStrongБұлСөзСөздіктенТабылмадыDiv;

        #endregion worning

        public static String containerend = "</div>";

        #endregion container

        public static String wikihead = Baq_Sozdik.Properties.Resources.DivClassContainerSpanStyleColorRgb10519560FontSize28pxУикипедияғаSpan;
        public static String wikiend = "</div>";

        public static String bodyend = "</body>";

        #endregion body

        public static String end = "</html>";

        #endregion head
    }
}
