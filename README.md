# XAF �P n8n �� AI ��Ѿ�X

![XAF n8n Chat](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/xafchat.png)

���M�׮i�ܦp��ϥ� Blazor UI�A�N XAF �� AI ��ѥ\��P n8n ��X�C����X�i��{ XAF �� AI �A�ȻP n8n �u�@�y�{�۰ʤƥ��x�������L�_�q�H�C

## ���z

���ѨM��ץi��{�G
- **XAF AI ���**�G�� AI �X�ʪ����ʦ���ܨt�ΡC
- **n8n ��X**�G�z�L n8n �u�@�y�{�^����Ѩƥ�ð�������ʧ@�A�۰ʤƳB�z�y�{�C

## ���M����

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Blazor Server �D������
- �@�ӥi�B�@�� n8n ��ҡ]�۬[�ζ��ݪ����^
- �w�ҥ� AI ��ѥ\�઺ XAF �]�w

## �w�˻P�]�w

### 1. �]�w XAF AI ��ѥ\��

- �ƻs XAF �M��
    ```bash
    git clone https://github.com/antonylu0826/XafN8nChat.git
    ```
### 2. �]�w n8n

- �ھکx�軡���w�˨ñҰ� n8n�G[n8n �w�˫��n](https://docs.n8n.io/getting-started/installation/)
- �إߥi�������ε{�����I�Ψƥ󪺤u�@�y�{�A�i�H�W���x�s�w�����d�Ҥu�@�y�{ ([n8n sample](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/Simple%20Chat.json))�C
![Sample Flow](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/simpleflow.png)
- ���o n8n �� webhook URL�A�o�N�Ω� Blazor Server �P n8n �������q�H�C
![WebHook Url](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/webhookurl.png)
    

### 3. ��s Blazor Server ���ε{��

- �b `Startup.cs` ���A��s�A�ȳ]�w�H�]�t XAF AI ��ѼҲաC
    ```csharp
    services.Addn8nChat(configureOptions => {
        configureOptions.ChatUrl = "<your_n8n_webhook_url>";
    });
    ```

�Ҧp�A�z������i�H�]�t�@�Ӱʧ@�A�ΨӱN��ѰT���o�e�� n8n webhook�G

## �������ε{��

1. **�ظm�ð��� Blazor Server �M��**  

## �����Ƹ�

- **API ���~�G** �T�{ webhook URL �O�_���T�A�B n8n �w�B��C
- **�]�w���D�G** �T�O XAF �� AI ��ѼҲջP n8n �]�w�]�Ҧp API ���_�^���T�L�~�C
- **�����s�u���D�G** ���� Blazor Server �P n8n ��Ҥ������s�u�O�_���`�C

## ��L�귽

- [XAF �x����](https://docs.devexpress.com/XAF)
- [n8n �x����](https://docs.n8n.io)
- [.NET 8 �x����](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)

�� README ���Ѿ�X XAF �� AI ��ѥ\��P n8n ��²�n���n�C�Ш̷ӱz��������һݨD�i��������վ�C
