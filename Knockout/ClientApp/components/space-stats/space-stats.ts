import * as ko from 'knockout';

class SpaceStatsViewModel {
    public name = ko.observable('');
}

export default { viewModel: SpaceStatsViewModel, template: require('./space-stats.html') };