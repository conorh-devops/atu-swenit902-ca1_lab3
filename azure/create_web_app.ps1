az appservice plan create --resource-group atu-swen-lab-3 --name atu-swen-asp-3 --is-linux

az webapp create --name atu-swen-app-3 --plan atu-swen-asp-3 --resource-group atu-swen-lab-3 --runtime "DOTNET|7.0"