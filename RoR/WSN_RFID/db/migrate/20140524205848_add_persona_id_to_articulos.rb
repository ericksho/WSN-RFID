class AddPersonaIdToArticulos < ActiveRecord::Migration
  def change
    add_column :articulos, :persona_id, :integer
  end
end
