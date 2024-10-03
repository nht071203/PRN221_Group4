﻿using System;
using System.Collections.Generic;

namespace ProjectPRNModel.Models;

public partial class Conversation
{
    public int ConversationId { get; set; }

    public string ConversationName { get; set; } = null!;

    public DateOnly CreateAt { get; set; }

    public int? CreatorId { get; set; }

    public int? MemberCount { get; set; }

    public bool? IsGroup { get; set; }

    public bool? IsDeleted { get; set; }

    public DateOnly? DeleteAt { get; set; }
}
