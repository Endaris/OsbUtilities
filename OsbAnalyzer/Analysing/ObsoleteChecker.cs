using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;

namespace OsbValidator.Obsolete
{
    public class ObsoleteChecker
    {
        public string CheckElement(VisualElement element)
        {
            string validationMessage = "";

            validationMessage = AppendValidationMessage(validationMessage, element, CheckDuplicates);
            validationMessage = AppendValidationMessage(validationMessage, element, CheckWhileFadedOut);
            validationMessage = AppendValidationMessage(validationMessage, element, CheckRedundantTransformation);
            validationMessage = AppendValidationMessage(validationMessage, element, CheckDefaultValueOverride);

            return validationMessage;
        }

        public List<string> CheckStoryboard(Storyboard storyboard)
        {
            List<string> obsolete = new List<string>();

            foreach(VisualElement element in storyboard.OsbElements)
            {
                string elementObsolete = CheckElement(element);
                if (!string.IsNullOrEmpty(elementObsolete))
                    obsolete.Add(elementObsolete);
            }

            return obsolete;
        }

        private string AppendValidationMessage(string message, VisualElement visualElement, Func<VisualElement,string> func)
        {
            string funcMessage = func.Invoke(visualElement);

            if (!string.IsNullOrEmpty(funcMessage))
            {
                if (string.IsNullOrEmpty(message))
                {
                    return funcMessage;
                }
                else
                {
                    return message + "\r\n" + funcMessage;
                }
            }
            return message;
        }

        public string CheckDuplicates(VisualElement element)
        {
            //element.Commands.GroupBy(c => c.Identifier);
            return "";
        }

        public string CheckWhileFadedOut(VisualElement element)
        {
            return "";
        }

        public string CheckRedundantTransformation(VisualElement element)
        {
            return "";
        }

        public string CheckDefaultValueOverride(VisualElement element)
        {
            return "";
        }
    }
}
