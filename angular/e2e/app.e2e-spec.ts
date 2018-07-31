import { DotnetAngularDemoTemplatePage } from './app.po';

describe('DotnetAngularDemo App', function() {
  let page: DotnetAngularDemoTemplatePage;

  beforeEach(() => {
    page = new DotnetAngularDemoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
