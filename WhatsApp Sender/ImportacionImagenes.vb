Module ImportacionImagenes
    Sub importarImagen(ByVal ofdImagen As OpenFileDialog, ByVal ruta As TextBox)
        ofdImagen.Filter = "Image files (*.dib, *.webp, *.jpeg, *.svgz, *.gif) | *.jpg; *.ico; *.png; *.svg; *.tif; *.xbm; *.bmp; *.jfif; *.pjp; *.tiff; *.mp4; *.m4u; *.3gpp; *.mov"
    End Sub
End Module
