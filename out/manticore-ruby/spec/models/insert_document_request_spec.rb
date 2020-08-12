=begin
#Manticore Search Client

#Please note that this client is experimental. For full documentation of the API methods consult https://manual.manticoresearch.com/. 

The version of the OpenAPI document: 1.0.0
Contact: info@manticoresearch.com
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.0.0-SNAPSHOT

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OpenapiClient::InsertDocumentRequest
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'InsertDocumentRequest' do
  before do
    # run before each test
    @instance = OpenapiClient::InsertDocumentRequest.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of InsertDocumentRequest' do
    it 'should create an instance of InsertDocumentRequest' do
      expect(@instance).to be_instance_of(OpenapiClient::InsertDocumentRequest)
    end
  end
  describe 'test attribute "index"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "id"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "doc"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
