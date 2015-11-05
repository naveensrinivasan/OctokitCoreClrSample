## Octokit coreclr sample

This is a sample for building octokit using coreclr.

The repo that has the coreclr changes to octokit is [Octokit](https://github.com/naveensrinivasan/octokit.net/tree/core-clr)

To run this you would need coreclr / aspnetnetbeta8

Here is what my `dnvm` look's like

```
➜  OctokitCoreClrSample git:(master) ✗ dnvm list

Active              Version Runtime Architecture OperatingSystem Alias
------              ------- ------- ------------ --------------- -----
                1.0.0-beta6    mono                    linux/osx 
                1.0.0-beta7 coreclr          x64       darwin 
                1.0.0-beta7    mono                    linux/osx 
     *          1.0.0-beta8 coreclr          x64       darwin   default
                1.0.0-beta8    mono                    linux/osx 
            1.0.0-rc1-15838    mono                    linux/osx 
```

### Nuget.Config Changes
Here is my nuget.config changes to include `my own` the location for the `Octokit.0.17.0-beta.nupkg`

```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
      <add key="nuget.org" value="https://www.nuget.org/api/v2/" />
      <add key="beta" value="https://www.myget.org/F/aspnetbeta8/api/v2" />
      <add key="My Own" value="/Users/naveen/Dropbox" />
  </packageSources>
  <disabledPackageSources>
  </disabledPackageSources>  <activePackageSource>    <add key="nuget.org" value="https://www.nuget.org/api/v2/" />  </activePackageSource>
</configuration>
```

### Run the sample

* Clone the repo
* Include the location to Nuget.config to locate `Octokit.0.17.0-beta.nupkg`
* `dnu restore`
* `dnu build --framework dnxcore50`
* `dnx ConsoleApplication`
