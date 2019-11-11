# How to reproduce case corruption?

1. Enter your `URL` and `Secret` in _Startup.cs_ file (`ConfigureServices` method)

2. Run project using `dotnet run` or `Press F5`

3. Use Postman and call `GET https://localhost:<PORT>/api/values` or simply open your browser using the url

4. Check hangfire dashboard using `https://localhost:<PORT>/hangfire/jobs/scheduled`

5. Use DocumentDB Storage Explorer to find corrupted document which uses camelCase instead of PascalCase
