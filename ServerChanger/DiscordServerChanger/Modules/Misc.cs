using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

public class Misc : ModuleBase<SocketCommandContext>
{
	[Command("echo")]
    public async Task Echo([Remainder]string message)
    {
        var embed = new EmbedBuilder();
        embed.WithTitle("Echoed Message");
        embed.WithDescription(message);
        embed.WithColor(new Color(0, 255, 0));

        await ReplyAsync("", false, embed.Build());
    }
    [Command("userinfo")]
    public async Task Userinfo()
    {
        var embed = new EmbedBuilder();
        embed.WithTitle("Echoed Message");
        embed.WithDescription(Context.User.ToString());
        embed.WithColor(new Color(0, 255, 0));

        await ReplyAsync("", false, embed.Build());
    }
    [Command("ip")]
    public async Task pick([Remainder]string message)
    {
        string[] options = message.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        string ip = options[0].Replace(' ', '/');
        string pw = options[1].Trim().Split(' ')[1];
        string link = "steam://" + ip + "/" + pw;

        var embed = new EmbedBuilder();
        embed.WithTitle("steam");
        embed.WithDescription(link);
        embed.WithColor(new Color(0, 255, 0));
       
        await ReplyAsync("", false, embed.Build());
    }
}
