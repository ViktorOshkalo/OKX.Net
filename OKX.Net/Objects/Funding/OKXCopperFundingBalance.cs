namespace OKX.Net.Objects.Funding;

/// <summary>
/// Copper funding balance
/// </summary>
[SerializationModel]
public record OKXCopperFundingBalance
{
    /// <summary>
    /// ["<c>ccy</c>"] Asset
    /// </summary>
    [JsonPropertyName("ccy")]
    public string Asset { get; set; } = string.Empty;

    /// <summary>
    /// ["<c>delegatedBal</c>"] Delegated balance
    /// </summary>
    [JsonPropertyName("delegatedBal")]
    public decimal DelegatedBalance { get; set; }

    /// <summary>
    /// ["<c>fundingBal</c>"] Funding balance
    /// </summary>
    [JsonPropertyName("fundingBal")]
    public decimal FundingBalance { get; set; }
}