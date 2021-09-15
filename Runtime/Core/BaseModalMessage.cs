﻿namespace GE.ModalWindows
{
    public abstract class BaseModalMessage
    {
        public void Enqueue() => ModalWindowsController.Enqueue(this);
        public void Show() => ModalWindowsController.Show(this);
    }
}