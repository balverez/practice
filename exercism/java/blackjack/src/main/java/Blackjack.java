import java.util.Map;

public class Blackjack {
    private static final int _blackjack = 21;
    private static final int _standThreshold = 17;
    private static final int _hitThreshold = 11;
    private static final int _largeHandThreshold = 20;
    private static final int _dealerAutoWinThreshold = 10;
    private static final int _dealerHitThreshold = 7;
    private static final String _stand = "S";
    private static final String _hit = "H";
    private static final String _split = "P";
    private static final String _autoWin = "W";

    private static final Map<String, Integer> _cardMap = Map.ofEntries(
            Map.entry("ace", 11),
            Map.entry("two", 2),
            Map.entry("three", 3),
            Map.entry("four", 4),
            Map.entry("five", 5),
            Map.entry("six", 6),
            Map.entry("seven", 7),
            Map.entry("eight", 8),
            Map.entry("nine", 9),
            Map.entry("ten", 10),
            Map.entry("jack", 10),
            Map.entry("queen", 10),
            Map.entry("king", 10)
    );

    public int parseCard(String card) {
        if (_cardMap.containsKey(card)) {
            return _cardMap.get(card);
        }

        return 0;
    }

    public boolean isBlackjack(String card1, String card2) {
        return parseCard(card1) + parseCard(card2) == _blackjack;
    }

    public String largeHand(boolean isBlackjack, int dealerScore) {
        if (!isBlackjack) {
            return _split;
        }
        else if (dealerScore < _dealerAutoWinThreshold) {
            return _autoWin;
        }

        return _stand;
    }

    public String smallHand(int handScore, int dealerScore) {
        if (handScore >= _standThreshold) {
            return _stand;
        }
        else if (handScore <= _hitThreshold || dealerScore >= _dealerHitThreshold) {
            return _hit;
        }

        return _stand;
    }

    // FirstTurn returns the semi-optimal decision for the first turn, given the cards of the player and the dealer.
    // This function is already implemented and does not need to be edited. It pulls the other functions together in a
    // complete decision tree for the first turn.
    public String firstTurn(String card1, String card2, String dealerCard) {
        int handScore = parseCard(card1) + parseCard(card2);
        int dealerScore = parseCard(dealerCard);

        if (_largeHandThreshold < handScore) {
            return largeHand(isBlackjack(card1, card2), dealerScore);
        } else {
            return smallHand(handScore, dealerScore);
        }
    }
}
