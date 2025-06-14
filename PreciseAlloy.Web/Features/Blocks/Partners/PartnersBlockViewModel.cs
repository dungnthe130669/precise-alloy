﻿using PreciseAlloy.Models.Blocks;

namespace PreciseAlloy.Web.Features.Blocks.Partners;

public class PartnersBlockViewModel(PartnersBlock currentBlock)
    : BlockViewModel<PartnersBlock>(currentBlock)
{
    public IList<PartnerBlock>? Partners { get; set; }
}
