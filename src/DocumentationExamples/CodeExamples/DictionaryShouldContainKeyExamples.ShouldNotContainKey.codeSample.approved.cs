var websters = new Dictionary<string, string> { { "Chazzwazzers", "What Australians would have called a bull frog." } };
websters.ShouldNotContainKey("Chazzwazzers");