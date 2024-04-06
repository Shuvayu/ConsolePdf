# ConsolePdf
PDF Console App written in C#

## Alternative 

- https://gist.github.com/ahmed-musallam/27de7d7c5ac68ecbd1ed65b6b48416f9

```
 .\gswin64c.exe `
-q -dNOPAUSE -dBATCH -dSAFER `
-sDEVICE=pdfwrite `
-dCompatibilityLevel="1.4" `
-dPDFSETTINGS=/screen `
-dEmbedAllFonts=true `
-dSubsetFonts=true `
-dColorImageDownsampleType=/Bicubic `
-dColorImageResolution=144 `
-dGrayImageDownsampleType=/Bicubic `
-dGrayImageResolution=144 `
-dMonoImageDownsampleType=/Bicubic `
-dMonoImageResolution=144 `
-sOutputFile="output.pdf" "input.pdf" `
```
