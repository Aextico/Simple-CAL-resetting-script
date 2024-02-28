## Resetting Trial CAL License in Windows

### Description
This code is designed to reset the trial Client Access License (CAL) in Windows by removing specific registry keys.

### How does it work   
The program first checks if there is a running instance of the "mstsc" application (Remote Desktop Connection). If such an instance exists, it is closed. Then, registry keys related to trial CAL licenses are removed. After removing these keys, the "mstsc.exe" application is restarted with admin rights to apply the changes.

### Requirements
- .NET Framework
- Administrator privileges

### Usage
1. Compile the code in an environment supporting .NET Framework.
2. Run the generated executable file.
3. The code will automatically reset the trial CAL license for the Remote Desktop Connection application.

