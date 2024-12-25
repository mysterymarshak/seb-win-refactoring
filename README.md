<!-- # Safe Exam Browser, Version 3.x

Refactored version of Safe Exam Browser for Windows with Chromium as integrated browser engine.

## Requirements

> [!NOTE]  
> Starting with version 3.8.0, Safe Exam Browser for Windows requires a minimum operating system version of **Windows 10 version 1803**.

Safe Exam Browser for Windows requires the prerequisites listed below in order to work correctly. These are automatically installed with the setup bundle and need only be manually installed when using the MSI packages.

* .NET Framework 4.8 Runtime: https://dotnet.microsoft.com/download/dotnet-framework/net48
* Visual C++ 2015-2019 Redistributable: https://support.microsoft.com/en-us/help/2977003/the-latest-supported-visual-c-downloads

## Project Status

> [!WARNING]
> **The builds linked below are for testing purposes only.** They may be unstable and should thus _never_ be used in a production environment! Always use the latest, official release version of SEB.

| Aspect            | Status                                                                                                                | Details                                                         |
| ----------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------- |
| Development Build | ![Development Build Status](https://sebdev.ethz.ch/api/projects/status/kq78qrjtnpk82ti0?svg=true)                     | https://sebdev.ethz.ch/project/appveyor/seb-win-refactoring     |
| Test Build        | ![Test Build Status](https://ci.appveyor.com/api/projects/status/a56akt9r174570m7?svg=true)                           | https://ci.appveyor.com/project/dbuechel/seb-win-refactoring    |
| Test Run          | ![AppVeyor Tests](https://img.shields.io/appveyor/tests/dbuechel/seb-win-refactoring?logo=appveyor&logoColor=%23ccc)  | https://ci.appveyor.com/project/dbuechel/seb-win-refactoring    |
| Code Coverage     | ![Code Coverage](https://codecov.io/gh/SafeExamBrowser/seb-win-refactoring/branch/master/graph/badge.svg)             | https://codecov.io/gh/SafeExamBrowser/seb-win-refactoring       |
| Issue Status      | ![GitHub Issues](https://img.shields.io/github/issues/safeexambrowser/seb-win-refactoring?logo=github)                | https://github.com/SafeExamBrowser/seb-win-refactoring/issues   |
| Downloads         | ![GitHub All Releases](https://img.shields.io/github/downloads/safeexambrowser/seb-win-refactoring/total?logo=github) | https://github.com/SafeExamBrowser/seb-win-refactoring/releases |
| Development       | ![GitHub Last Commit](https://img.shields.io/github/last-commit/safeexambrowser/seb-win-refactoring?logo=github)      | n/a                                                             |
| Repository Size   | ![GitHub Repo Size](https://img.shields.io/github/repo-size/safeexambrowser/seb-win-refactoring?logo=github)          | n/a                                                             | -->

# Safe Exam Browser 3.8.0 patched

Что было измененно:
- Добавлен SyncShare
- Подделаны все логи (типа, да, выключено это, выключено то, да, точно не вм и все остальное ...)
- Рабочий clipboard (не очищается, не изолирован внутри браузера, пользуемся как обычно)
- Убран красный lockscreen (code signatiure verifying)
- Сделана замена компонентов пк (motherboard & monitors)
- Подделаны мониторы (всегда возвращается один, валидный)
- VM разрешена
- Kiosk bypass (серая хрень, которая перекрывает рабочий стол)
- Окно браузера resizable
- Монитор процессов bypass (игнор блэклиста, запуска процессов - они не логируются)
- Hot keys разрешены
- Cursor verification mock (да, с кастомными курсорами бразуер даже не запускался, теперь можно)
- И много чего еще для нормальной жизни..

## Гайд как поставить данный patch
0. [Скачивайте и устанавливаете SEB 3.8.0](https://github.com/SafeExamBrowser/seb-win-refactoring/releases/tag/v3.8.0)

1. [Скачивайте последний релиз](https://github.com/mysterymarshak/seb-win-refactoring/releases)

2. Распакуйте все файлы в папку ```Application``` (```C:\Program Files\SafeExamBrowser\Application```)

3. Дальше можете открывать сам браузер либо через конфиг и тестировать.
