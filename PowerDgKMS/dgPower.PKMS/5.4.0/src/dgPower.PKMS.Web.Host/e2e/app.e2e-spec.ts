import { PKMSTemplatePage } from './app.po';

describe('PKMS App', function() {
  let page: PKMSTemplatePage;

  beforeEach(() => {
    page = new PKMSTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
