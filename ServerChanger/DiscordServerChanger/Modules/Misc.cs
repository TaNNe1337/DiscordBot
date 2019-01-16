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

        await Context.Channel.SendMessageAsync("", false, embed.Build());
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
}
