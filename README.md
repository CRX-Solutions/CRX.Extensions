# CRX.Extensions ![CRX.Extensions Nuget Package](https://img.shields.io/nuget/dt/CRX.Extensions) ![BuildAndTest](https://github.com/CRX-Solutions/CRX.Extensions/workflows/BuildAndTest/badge.svg)
Useful extensions for your .Net project developed by **CRX Solutions**.

## Extensions
### Bool Extensions
Method Name | Return Type | Description
------------|-------------|-------------
**ToYesNo**|string|Converts the value of the bool to 'Yes' or 'No'.

### Enum Extensions
Method Name | Return Type | Description
------------|-------------|-------------
**ToDisplay**|string|By default this method replaces the underscores within an enum with spaces to make it suitable for display to user.<br/>You can pass the a different character to replace with a space.

### String Extensions
Method Name | Return Type | Description
------------|-------------|-------------
**ToEnum**|Enum|This method converts a string into an enum of the type specified
**ToTitleCase**|string|This method converts the string into title case. <br/>You can specify whether or not to replace words which are all in caps lock.

### Generic Extensions
Method Name | Return Type | Description
------------|-------------|-------------
**In**|bool|This method return whether or not the speciedied object contains the list of objects passed.

## Versions
### 1.0.0
This was the initial version

### Upcoming Features
- [x] Generic Enum ToTitle

## Contribution & Feedback
Please feel free to use this component and do not hesitate to open an issue should you encouter any.
<br/>You are more then welcome to share your feedback with us regarding this component.
