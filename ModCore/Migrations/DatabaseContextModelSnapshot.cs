﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ModCore.Database;
using ModCore.Entities;
using System;

namespace ModCore.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("ModCore.Database.DatabaseBan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("BanReason")
                        .HasColumnName("ban_reason");

                    b.Property<long>("GuildId")
                        .HasColumnName("guild_id");

                    b.Property<DateTime>("IssuedAt")
                        .HasColumnName("issued_at")
                        .HasColumnType("timestamptz");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("mcore_bans");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseCommandId", b =>
                {
                    b.Property<string>("Command")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("command_qualified");

                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGeneratedOnAdd", true)
                        .HasAnnotation("Sqlite:Autoincrement", true)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Command");

                    b.HasAlternateKey("Id")
                        .HasName("id");

                    b.ToTable("mcore_cmd_state");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseGuildConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("GuildId")
                        .HasColumnName("guild_id");

                    b.Property<string>("Settings")
                        .IsRequired()
                        .HasColumnName("settings")
                        .HasColumnType("jsonb");

                    b.HasKey("Id");

                    b.HasIndex("GuildId")
                        .IsUnique()
                        .HasName("mcore_guild_config_guild_id_key");

                    b.ToTable("mcore_guild_config");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("MetaKey")
                        .IsRequired()
                        .HasColumnName("meta_key");

                    b.Property<string>("MetaValue")
                        .IsRequired()
                        .HasColumnName("meta_value");

                    b.HasKey("Id");

                    b.HasIndex("MetaKey")
                        .IsUnique()
                        .HasName("mcore_database_info_meta_key_key");

                    b.ToTable("mcore_database_info");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseModNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Contents")
                        .HasColumnName("contents");

                    b.Property<long>("GuildId")
                        .HasColumnName("guild_id");

                    b.Property<long>("MemberId")
                        .HasColumnName("member_id");

                    b.HasKey("Id");

                    b.HasIndex("MemberId", "GuildId")
                        .IsUnique()
                        .HasName("mcore_modnotes_member_id_guild_id_key");

                    b.ToTable("mcore_modnotes");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseRolestateOverride", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("ChannelId")
                        .HasColumnName("channel_id");

                    b.Property<long>("GuildId")
                        .HasColumnName("guild_id");

                    b.Property<long>("MemberId")
                        .HasColumnName("member_id");

                    b.Property<long?>("PermsAllow")
                        .HasColumnName("perms_allow");

                    b.Property<long?>("PermsDeny")
                        .HasColumnName("perms_deny");

                    b.HasKey("Id");

                    b.HasIndex("MemberId", "GuildId", "ChannelId")
                        .IsUnique()
                        .HasName("mcore_rolestate_overrides_member_id_guild_id_channel_id_key");

                    b.ToTable("mcore_rolestate_overrides");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseRolestateRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("GuildId")
                        .HasColumnName("guild_id");

                    b.Property<long>("MemberId")
                        .HasColumnName("member_id");

                    b.Property<long[]>("RoleIds")
                        .HasColumnName("role_ids");

                    b.HasKey("Id");

                    b.HasIndex("MemberId", "GuildId")
                        .IsUnique()
                        .HasName("mcore_rolestate_roles_member_id_guild_id_key");

                    b.ToTable("mcore_rolestate_roles");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseStarData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("AuthorId")
                        .HasColumnName("author_id");

                    b.Property<long>("ChannelId")
                        .HasColumnName("channel_id");

                    b.Property<long>("GuildId")
                        .HasColumnName("guild_id");

                    b.Property<long>("MessageId")
                        .HasColumnName("message_id");

                    b.Property<long>("StarboardMessageId")
                        .HasColumnName("starboard_entry_id");

                    b.Property<long>("StargazerId")
                        .HasColumnName("stargazer_id");

                    b.HasKey("Id");

                    b.HasIndex("MessageId", "ChannelId", "StargazerId")
                        .IsUnique()
                        .HasName("mcore_stars_member_id_guild_id_key");

                    b.ToTable("mcore_stars");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("ChannelId")
                        .HasColumnName("channel_id");

                    b.Property<string>("Contents")
                        .HasColumnName("contents");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamptz");

                    b.Property<string>("Name")
                        .HasColumnName("tagname");

                    b.Property<long>("OwnerId")
                        .HasColumnName("owner_id");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId", "Name")
                        .IsUnique()
                        .HasName("mcore_tags_channel_id_tag_name_key");

                    b.ToTable("mcore_tags");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseTimer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ActionData")
                        .IsRequired()
                        .HasColumnName("action_data")
                        .HasColumnType("jsonb");

                    b.Property<int>("ActionType")
                        .HasColumnName("action_type");

                    b.Property<long>("ChannelId")
                        .HasColumnName("channel_id");

                    b.Property<DateTime>("DispatchAt")
                        .HasColumnName("dispatch_at")
                        .HasColumnType("timestamptz");

                    b.Property<long>("GuildId")
                        .HasColumnName("guild_id");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("mcore_timers");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseWarning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("GuildId")
                        .HasColumnName("guild_id");

                    b.Property<DateTime>("IssuedAt")
                        .HasColumnName("issued_at")
                        .HasColumnType("timestamptz");

                    b.Property<long>("IssuerId")
                        .HasColumnName("issuer_id");

                    b.Property<long>("MemberId")
                        .HasColumnName("member_id");

                    b.Property<string>("WarningText")
                        .IsRequired()
                        .HasColumnName("warning_text");

                    b.HasKey("Id");

                    b.ToTable("mcore_warnings");
                });
#pragma warning restore 612, 618
        }
    }
}