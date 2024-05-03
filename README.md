
# Blood Sugar Correction Calc

Description: Simple script to return the amount of insulin needed to correct blood sugar to normal levels

## Deployment

To build in MacOS (M Series chips)
Navigate to folder labeled "BloodSugar_Correction_Calculator/CorrectionCalculator/bin/Release/net8.0"\

```bash
dotnet publish -c Release -r osx-arm64 --self-contained -p:PublishTrimmed=true -p:PublishReadyToRun=true
```
To build in Windows (Intel/Amd chips)
```bash
dotnet publish -c Release -r win-x64 --self-contained -p:PublishTrimmed=true -p:PublishReadyToRun=true
```
## Installation
Unzip the folder and place in long-term storage location \

Install per user: (OSX/LINUX)
```bash
ln -s CorrectionCalculator ~/bin/bscalc
```
Then add the "bin" folder to your PATH variable and your set!

Install per user: (WINDOWS)
```bash
ln -s CorrectionCalculator.exe ~/bin/bscalc
```
Then add the "bin" folder to your PATH variable and your set!
