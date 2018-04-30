# SimpleSoundBoard
Simple Soundboard to play audio files via keyboard shortcuts
![GUI](/images/GUI.png)
## How to use
After running the application a small Icon will appear on your task bar:

![SoundFile_16x](/images/SoundFile_16x.png)

Double-clicking this Icon will open the GUI as seen in the first image. A click on one of the speaker icons

![SoundFile_16x](/images/Speaker.png)

will open a file dialog in whick you can select the file that shoud be played. When a incompatible file type is selected nothing will happen when triggering the shortcut.

---

*The shortcuts can be triggered whenever you want as long as the application is running. Simply press **CTRL+SHIFT+[F1-F12]** to play the corresponding file.*

---

Selected files will be saved in the settings and are persistent over restarts of the application.
## Supported formats
This application uses the [WindowsMediaPlayer-Class](https://msdn.microsoft.com/de-de/library/system.windows.media.mediaplayer(v=vs.110).aspx) and thus plays [all formats supported by Windows MediaPlayer](https://support.microsoft.com/de-de/help/316992/file-types-supported-by-windows-media-player).
