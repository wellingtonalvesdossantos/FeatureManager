using FeatureManager.Core.Appliers;

namespace FeatureManager.Core
{
    public class FeatureActionValidator
    {
        private readonly WhenApplier _whenApplier;
        private readonly WhereApplier _whereApplier;
        private readonly WhoApplier _whoApplier;

        public FeatureActionValidator(WhenApplier whenApplier, WhereApplier whereApplier, WhoApplier whoApplier)
        {
            _whenApplier = whenApplier;
            _whereApplier = whereApplier;
            _whoApplier = whoApplier;
        }

        public FeatureActionValidationResult Validate(FeatureAction action)
        {
            var result = new FeatureActionValidationResult();
            foreach (var block in action.RestrictionBlocks)
            {
                var blockResultItems = new Dictionary<string, bool>();
                foreach (var when in block.When)
                {
                    var applierResult = _whenApplier.IsMatch(when);
                    blockResultItems.Add($"{block.Name} | {when}", applierResult);
                }
                foreach (var where in block.Where)
                {
                    var applierResult = _whereApplier.IsMatch(where, action.Geolocation!);
                    blockResultItems.Add($"{block.Name} | {where}", applierResult);
                }
                foreach (var who in block.Who)
                {
                    var applierResult = _whoApplier.IsMatch(who);
                    blockResultItems.Add($"{block.Name} | {who}", applierResult);
                }
                var resultItem = new FeatureActionValidationItemResult(block, blockResultItems);
                result.Items.Add(resultItem);
            }
            return result;
        }
    }

    public class FeatureActionValidationResult
    {
        public bool IsValid => !Items.Any(item => item.Items.Any(i => !i.Value));
        public List<FeatureActionValidationItemResult> Items { get; set; } = new();
    }

    public class FeatureActionValidationItemResult
    {
        public FeatureActionValidationItemResult(RestrictionBlock block, Dictionary<string, bool> dic)
        {
            Block = block;
            Items = dic;
        }

        public RestrictionBlock Block { get; }
        public Dictionary<string, bool> Items { get; } = new();

        public override string? ToString() => Block.ToString();
    }
}
