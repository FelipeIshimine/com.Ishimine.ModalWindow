using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace GE.ModalWindows.Modal
{
    public class TextWithImageWindow : GenericModalWindow<TextWithImageMessage>
    {
        public Image image;
        public TextMeshProUGUI TextMesh;
        private TextWithImageMessage _message;

        protected override void Initialize()
        {
            if (ModalMessage.pauseTime)
                Time.timeScale = 0;

            _message = ModalMessage;
            image.sprite = ModalMessage.sprite;
            TextMesh.text = ModalMessage.body;
        }

        public override void Close()
        {
            if (_message.pauseTime)
                Time.timeScale = 1;

            _message.Callback?.Invoke();
            base.Close();
        }
    }
}
