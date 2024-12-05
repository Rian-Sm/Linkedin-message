# Script para iniciar mensagems com tech recruiter Linkedin

##  Environment Variables

Antes de executar o código é necessário atualizar as variáveis de ambiente do projeto.

| Variavel          | Type     | Description                |
| :--------         | :------- | :------------------------- |
| `YOUR_NAME`       | `string` | **Required**. URL do input do teste |
| `TIME_EXPERINCE`  | `string` | **Required**. Parametros de sessão do seu usuário no teste |
| `RULE`            | `string` | **Required**. Parametros de sessão do seu usuário no teste |
| `SKILLS`          | `string` | **Required**. Parametros de sessão do seu usuário no teste |

O arquivo com as informações de variáveis de ambiente esta no path `Properties\launchsettings.json.exemple`

## Execution

Para excutar o programa é necessario passar dois argumentos :

| ARGS      | Description                |
| :-------- | :------------------------- |
| `nome`     | **Required**. Nome do recrutador |
| `empresa`  | **Required**. Nome da empresa do recrutador |

```bash
  dotnet run <nome> <empresa>
```

  ## To Do

  Adicionar arquivos e lib de localização para poder se comunicar em diferentes países
